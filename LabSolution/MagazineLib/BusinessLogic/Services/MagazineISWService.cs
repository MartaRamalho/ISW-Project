﻿using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Services
{
    public class MagazineISWService : IMagazineISWService
    {
        // Dal persistence service
        private readonly IDAL dal;

        // Resources Manager for error messaging
        private ResourceManager resourceManager;

        // logged in User for verification purposes such as (not complete list):
        // - operations restricted to area editors
        // - operations restricted to chief editor
        // - submitted paper responsible author is logged in user
        private User loggedUser;


        private Entities.Magazine magazine;
        public MagazineISWService(IDAL dal)
        {
            this.dal = dal;

            // Resource manager for internationalization of error messages is created
            resourceManager = new ResourceManager("MagazineLib.Resources.ExceptionMessages", Assembly.GetExecutingAssembly());

            // Only one magazine object exists in our system
            magazine = dal.GetAll<Entities.Magazine>().FirstOrDefault();
            if (magazine == null)
            {
                DBInitialization();
            }
        }

        private void ValidateLoggedUser(bool validateLogged)
        {
            if (validateLogged)
            {
                // if user is not logged in and it should be logged in then generate exception
                if (loggedUser == null) throw new ServiceException(resourceManager.GetString("LoggedOutUser"));
            }
            else // if user is logged in and it should not be logged in then generate exception 
                if (loggedUser != null) throw new ServiceException(resourceManager.GetString("LoggedUser"));

        }

        public void DBInitialization()
        {
            // Chief editor registered
            RegisterUser("66666666A", "Javier", "Jaen", false, "HCI; Software Engineering", "fjaen@upv.es", "fjaen", "1234");

            // Area editors registered
            RegisterUser("77777777B", "Jorge", "Montaner", false, "Software Engineering", "jormonm5@upv.es", "jmontaner", "1234");
            RegisterUser("88888888C", "Fernando", "Alonso", false, "HCI", "falonso@upv.es", "falonso", "1234");

            // Author registered
            RegisterUser("99999999D", "Carlos", "Sainz", false, "HCI", "csainz@upv.es", "csainz", "1234");

            // Magazine created and stored in "magazine" reference
            int magazineId = AddMagazine("University Magazine", "66666666A");
            magazine = dal.GetById<Entities.Magazine>(magazineId);

            // Two Areas added, Login required because only chief editor is allowed to do this 
            Login("fjaen", "1234");
            AddArea("HCI", "77777777B");
            AddArea("Software Engineering", "88888888C");
            Logout();
        }

        public void Commit()
        {
            dal.Commit();
        }

        #region User
        //Create a new user in the system
        public void RegisterUser(string id, string name, string surnames, bool wantsToReceive, string fieldsOfIntereset, string email, string username, string password)
        {
            if (name == "" || surnames == "" || email == "" || username == "" || password == "")
            {
                throw new ServiceException("All obligatory fields must be provided.");
            }
            List<User> users = dal.GetAll<User>().ToList();
            foreach (User user in users)
            {
                if (user.Login.Equals(username))
                {
                    //No registration possible, LAUNCH EXECPTION
                    throw new ServiceException("Username already in use");
                }
                if (user.Id.Equals(id))
                {
                    //No registration possible, LAUNCH EXECPTION
                    throw new ServiceException("Invalid Id");
                }
            }
            //No user found with id, then we create the user and we push it to dal
            dal.Insert<User>(new User(id, name, surnames, wantsToReceive, fieldsOfIntereset, email, username, password));
            Commit();
        }

        public string GetCurrentUserId()
        {
            ValidateLoggedUser(true);
            return loggedUser.Id;
        }

        public string Login(string login, string password)
        {
            if (login == "" || password == "")
            {
                throw new ServiceException("Please fill all the fields");
            }
            List<User> users = dal.GetAll<User>().ToList();
            //Check if the user is in the users' list
            foreach (User u in users)
            {
                if (u.Login.Equals(login) && u.Password.Equals(password))
                {
                    ValidateLoggedUser(false);
                    loggedUser = u;
                    return u.Id;
                    //Creates a new session for the user        
                }
            }
            //No user found if the program arrives here
            throw new ServiceException("Login incorrect. Username or password may be wrong");
        }

        public void RegisterPerson(String id, String name, String surname)
        {
            Person person = GetPersonById(id);
            if (person != null)
            {
                throw new ServiceException("Person already registered");
            }
            if (name == "" || surname == "")
            {
                throw new ServiceException("Please fill all the fields");
            }
            //No person found with id, then we create the person and we push it to dal
            dal.Insert<Person>(new Person(id, name, surname));
            Commit();
        }
        //returns a list of the people stored in the database
        public List<string> GetListPeople()
        {
            List<string> listPeople = new List<string>();
            List<Person> people = dal.GetAll<Person>().ToList();
            foreach (Person person in people)
            {
                listPeople.Add(person.Id);
            }
            return listPeople;
        }

        public string GetFullName(string personId)
        {
            Person person = GetPersonById(personId);
            if (person == null)
            {
                throw new ServiceException("Person does not exist.");
            }
            return person.GetFullName();
        }

        public Person GetPersonById(String id)
        {
            Person person = dal.GetById<Person>(id);
            return person;
        }

        public void Logout()
        {
            ValidateLoggedUser(true);
            loggedUser = null;
        }

        public bool IsChiefEditor()
        {
            return loggedUser.Magazine != null;
        }

        public bool IsAreaEditor()
        {
            return loggedUser.Area != null;
        }
        public int GetEditorArea()
        {
            if(!IsAreaEditor())
                throw new ServiceException("User not allowed.");
            return loggedUser.Area.Id;
        }


        #endregion

        #region Paper

        public int SubmitPaper(int areaId, string title, DateTime uploadDate)
        {
            ValidateLoggedUser(true);
            Area area = magazine.getAreaById(areaId);
            if (area == null)
            {
                throw new ServiceException("Area not found.");
            }
            if (uploadDate == null || !uploadDate.Equals(DateTime.Today))
            {
                throw new ServiceException("Invalid Date.");
            }
            if (title == "")
            {
                throw new ServiceException("Invalid Title.");
            }
            
            Paper submittedPapper = new Paper(title, uploadDate, area, loggedUser);
            loggedUser.MainAuthoredPapers.Add(submittedPapper);
            submittedPapper.EvaluationPendingArea = area;
            area.AddPaper(submittedPapper);

            Commit();
            return submittedPapper.Id;
        }

        public void GetPaperById(int paperId, out string title, out DateTime date, out string user)
        {
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null)
                throw new ServiceException("This paper does not exist");
            title = paper.Title;
            date = paper.UploadDate;
            user = GetFullName(paper.Responsible.Id);
        }
        public Paper GetPaperById(int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null)
                throw new ServiceException("This paper does not exist");
            return paper;
        }

        public void EvaluatePaper(bool accepted, string comments, DateTime date, int paperId)
        {
            if(comments=="")
            {
                throw new ServiceException("Comments must be provided");
            }
            ValidateLoggedUser(true);
            if(date == null || !date.Equals(DateTime.Today))
            {
                throw new ServiceException("Invalid Date");
            }
            Paper paperToEvaluate = magazine.GetPaperById(paperId);
            if (paperToEvaluate == null)
            {
                throw new ServiceException("This paper does not exist");
            }
            if (paperToEvaluate.Evaluation != null)
            {
                throw new ServiceException("This paper has already been evaluated");
            }
            //We check if the loggedUser is the editor of the area it belongs to
            if(paperToEvaluate.EvaluationPendingArea.Editor.Equals(loggedUser))
            {
                paperToEvaluate.EvaluatePaper(accepted, comments, date);
                Commit();
            }
            else
            {
                throw new ServiceException("You do not have permissions to evaluate this paper.");
            }
        }

        public bool isEvaluationPending(int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null) throw new ServiceException("Paper not found");
            return paper.EvaluationPendingArea != null;
        }

        public void AddCoAuthors(string personId, int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            Person person = GetPersonById(personId);
            if (person == null)
            {
                throw new ServiceException("Person not found");
            }
            if (paper == null)
            {
                throw new ServiceException("Paper not found");
            }
            List<Person> coAuthors = paper.CoAuthors.ToList();
            if (coAuthors.Count >= 5)
            {
                throw new ServiceException("Maximum Number Of Co Authors Reached");
            }
            if (coAuthors.Contains(person))
            {
                throw new ServiceException("Repeated Authors");
            }
            coAuthors.Add(person);
            person.CoAuthoredPapers.Add(paper);
            Commit();
        }

        public void PublishPaper(int paperId)
        {
            ValidateLoggedUser(true);
            if (!IsChiefEditor())
            {
                throw new ServiceException("Invalid User");
            }
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null)
            {
                throw new ServiceException("Paper not found");
            }
            //Check if the paper is pending of publication
            if (isPublicationPending(paperId))
            {
                paper.publishPaper();
                int idIssue = BuildIssue();
                paper.Issue = magazine.GetIssueById(idIssue);
            }
            else
            {
                throw new ServiceException("Paper Already Published");
            }

            Commit();
        }


        //Checking that is published because the issue is not null
        public bool isPublishedPaper(int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null)
            {
                throw new ServiceException("Paper not found");
            }
            return paper.Issue != null;
        }

        public void UnPublishPaper(int paperId)
        {
            ValidateLoggedUser(true);
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            //Check that the paper is published
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null)
            {
                throw new ServiceException("Paper not found");
            }
            if (isPublishedPaper(paperId))
            {
                paper.UnpublishPaper();

            }
            else
            {
                throw new ServiceException("Paper Not Published");
            }
            Commit();

        }


        public bool isPublicationPending(int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null)
            {
                throw new ServiceException("Paper not found");
            }
            return paper.PublicationPendingArea != null;
        }

        public bool isAccepted(int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null)
            {
                throw new ServiceException("Paper not found");
            }
            return paper.isAccepted();
        }

        public ICollection<int> ListAllPapers() 
        {
            ValidateLoggedUser(true);
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            ICollection<int> allPapers = magazine.ListAllPapers();
            return allPapers;
        }

        public ICollection<int> ListAllPapersByIssue(int idIssue)
        {
            ValidateLoggedUser(true);
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            Issue issue = magazine.GetIssueById(idIssue);
            if (issue == null)
            {
                throw new ServiceException("Issue not found");
            }
            return issue.GetPapers();
        }

        public ICollection<int> ListPapersInAreaPendingEvaluation(int areaId)
        {
            ValidateLoggedUser(true);
            Area area = magazine.getAreaById(areaId);
            if (area == null)
            {
                throw new ServiceException("Area not found");
            }            
            return area.GetPapersPendingEvaluation();
        }

        public ICollection<int> ListPapersInAreaPendingPublication(int areaId)
        {
            ValidateLoggedUser(true);
            Area area = magazine.getAreaById(areaId);
            if (area == null)
            {
                throw new ServiceException("Area not found");
            }
            return area.GetPapersPendingPublication();
        }


        public ICollection<string> ListAllAuthors(int paperId)
        {
            ValidateLoggedUser(true);
            Paper paper = magazine.GetPaperById(paperId);
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            if (paper == null)
            {
                throw new ServiceException("Paper not found");
            }
            return paper.AllAuthors();
        }

        //To list papers that are published in an area
        public ICollection<int> PublishedPapers(int areaId, int issueNum)
        {
            List<int> pubPapers = new List<int>();
            Area area = magazine.getAreaById(areaId);
            Issue issue = magazine.GetIssueByNumber(issueNum);
            if (area == null)
            {
                throw new ServiceException("Area not found");
            }
            if (issue == null)
            {
                throw new ServiceException("Issue not found");
            }
            foreach (Paper paper in area.Papers) 
            {
                if (isPublishedPaper(paper.Id) && paper.Issue.Equals(issue))
                { 
                    pubPapers.Add(paper.Id);
                }
            }
            return pubPapers;
        }
        

        #endregion


        #region Issue

        public int AddIssue(int number)
        {
            // validate logged user
            ValidateLoggedUser(true);
            //ValidateLoggedUser user is IsChiefEditor editor
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }

            // validate magazine exists
            if (magazine == null) throw new ServiceException("Magazine Does Not Exist");
            int issueNum=magazine.AddIssue(number).Number;
            Commit();
            return issueNum;
        }

        public int BuildIssue()
        {
            if (magazine == null) throw new ServiceException("Magazine Does Not Exist");
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            int number = 0;
            foreach (int id in magazine.GetListIssues())
            {
                Issue issue = magazine.GetIssueById(id);
                if (issue == null)
                {
                    throw new ServiceException("Issue not found");
                }
                if (issue.PublicationDate == null)
                {
                    return issue.Number;
                }
                number = issue.Number;
            }
            return AddIssue(number+1);
        }

        public ICollection<int> ListAllIssues()
        {
            if (magazine == null) throw new ServiceException("Magazine Does Not Exist");
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            return magazine.GetListIssues();
        }

        public void SaveIssue(int number, DateTime date)
        {
            ValidateLoggedUser(true);
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            if (date == null)
            {
                throw new ServiceException("Invalid Date");
            }
            Issue issue = magazine.GetIssueByNumber(number);
            if (issue.PublicationDate!=null)
            {
                throw new ServiceException("Issue already published");
            }
            else
            {
                magazine.PublishIssue(number, date);
                Commit();
            }
        }

        #endregion

        #region Area


        /// <summary>   Validate area and if correct, add a new area.</summary>
        /// <param>     <c>areaName</c> is the area name. 
        /// </param>     
        /// <param>     <c>editorId</c> is the Id of the area editor. 
        /// </param>
        /// <returns> 
        ///             Area id
        ///             Any required ServiceExceptions
        /// </returns>
        public int AddArea(string areaName, string editorId)
        {
            // validate logged user
            ValidateLoggedUser(true);

            // validate user is chief editor
            if (loggedUser.Magazine == null) throw new ServiceException(resourceManager.GetString("InvalidAddAreaUser"));

            // validate magazine exists
            if (magazine == null) throw new ServiceException(resourceManager.GetString("MagazineNotExists"));

            // validate area name not empty
            if ((areaName == null) || (areaName.Length == 0)) throw new ServiceException(resourceManager.GetString("InvalidAreaName"));

            // validate not another area with same name
            if (magazine.GetAreaByName(areaName) != null) throw new ServiceException(resourceManager.GetString("InvalidAreaName"));

            // validate editor id not empty
            if ((editorId == null) || (editorId.Length == 0)) throw new ServiceException(resourceManager.GetString("NullUserId"));

            //validate editor exists
            var editor = dal.GetById<User>(editorId);
            if (editor == null) throw new ServiceException(resourceManager.GetString("UserNotExists"));

            // inserts area
            Area area = new Area(areaName, editor, magazine);
            magazine.AddArea(area);
            Commit();
            return area.Id;
        }
        public string GetAreaName(int id)
        {
            return magazine.getAreaById(id).Name;
        }
        public ICollection<int> ListAllAreas()
        {
            return magazine.ListAreas();
        }

        public int GetAreaIdByName(string name)
        {
            Area area = magazine.GetAreaByName(name);
            if (area == null)
            {
                throw new ServiceException("Area not found");
            }
            return area.Id;
        }

        #endregion

        #region Magazine

        /// <summary>   Validate data and if correct, add a new magazine with its chief editor.</summary>
        /// <param>     <c>name</c> is the name of the magazine 
        /// </param>
        /// <param>     <c>chiefEditorId</c> is the is the user Id of that becomes chief Editor 
        /// </param>
        /// <returns>   
        ///             Magazine Id
        ///             Any required Service Exceptions 
        /// </returns>
        public int AddMagazine(string name, string chiefEditorId)
        {
            // validate magazine name not empty
            if ((name == null) || (name.Equals(""))) throw new ServiceException(resourceManager.GetString("InvalidMagazineName"));

            // validate chief editor id not empty
            if ((chiefEditorId == null) || (chiefEditorId.Length == 0)) throw new ServiceException(resourceManager.GetString("NullUserId"));

            // validate chief editor exists
            var chief = dal.GetById<User>(chiefEditorId);
            if (chief == null) throw new ServiceException(resourceManager.GetString("UserNotExists"));

            // insert magazine
            Entities.Magazine m = new Entities.Magazine(name, chief);
            dal.Insert(m);
            Commit();
            return m.Id;
        }

        #endregion
    }
}
using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
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
        public  MagazineISWService(IDAL dal){
            this.dal = dal;

            // Resource manager for internationalization of error messages is created
            resourceManager = new ResourceManager("MagazineLib.Resources.ExceptionMessages", Assembly.GetExecutingAssembly());
            
            // Only one magazine object exists in our system
            magazine = dal.GetAll<Entities.Magazine>().FirstOrDefault();
            if(magazine == null)
            {
                DBInitialization();
            }
        }

        private void ValidateLoggedUser(bool validateLogged)
        {
            if (validateLogged) {
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
            int magazineId = AddMagazine("University Magazine","66666666A");
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
            List<User> users = dal.GetAll<User>().ToList();
            foreach (User user in users)
            {
                if (user.Login.Equals(username))
                {
                    //No registration possible, LAUNCH EXECPTION
                    throw new ServiceException("Username already in use");
                }
            }
            //No user found with id, then we create the user and we push it to dal
            dal.Insert<User>(new User(id, name, surnames, wantsToReceive, fieldsOfIntereset, email, username, password));
            Commit();
        }

        public string Login(string login, string password) 
        {
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

        public bool isRegisteredUser(String personId) 
        {
            List<Person> people = GetListPeople();
            Person person =GetPersonById(personId);
            foreach(Person p in people)
            {
                if (person.Id.Equals(p.Id) || (person.Name.Equals(p.Name) && person.Surname.Equals(p.Surname)) ) {
                    return true;
                }
            }
            return false;
        }
        public void RegisterPerson(String id, String name, String surname)
        {
            //List<Person> people = GetListPeople();
            Person person = GetPersonById(id);
            if (person != null && !isRegisteredUser(id)) {  //Cambiar la comprobación de que exista la persona
                throw new ServiceException("Person already registered");
            }
            //No user found with id, then we create the user and we push it to dal
            dal.Insert<Person>(new Person(id, name, surname));
            Commit();
        }

        public List<Person> GetListPeople() {
            return dal.GetAll<Person>().ToList();
        }
        public Person GetPersonById (String id) {
            List<Person> people = GetListPeople();
            foreach (Person person in people)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            throw new ServiceException("Person not found");
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
        #endregion

        #region Paper

        public int SubmitPaper(int areaId, string title, DateTime uploadDate)
        {
            ValidateLoggedUser(true);
            Area area = magazine.getAreaById(areaId);
            if(area == null) { 
                throw new ServiceException("Area not found.");
            }
            Paper submittedPapper = new Paper(title, uploadDate, area, loggedUser);
            area.AddPaper(submittedPapper);
            Commit();
            return submittedPapper.Id;
        }

        

        
        //fix nullpointer exception
        public void EvaluatePaper(bool accepted, string comments, DateTime date, int paperId)
        {
            if(comments==null || date==null)
            {
                throw new ServiceException("Comments and Date cannot be null");
            }
            ValidateLoggedUser(true);
            Paper paperToEvaluate = magazine.GetPaperById(paperId);
            if (paperToEvaluate.Evaluation != null)
            {
                throw new ServiceException("This paper has already been evaluated");
            }
            //We check if the loggedUser is the editor of the area it belongs to
            if(paperToEvaluate.EvaluationPendingArea.Editor == loggedUser)
            {
                paperToEvaluate.Evaluation = new Evaluation(accepted, comments, date);
                if (accepted)
                {
                    paperToEvaluate.PublicationPendingArea = paperToEvaluate.EvaluationPendingArea;
                    paperToEvaluate.EvaluationPendingArea = null;
                    paperToEvaluate.PublicationPendingArea.EvaluationPending.Remove(paperToEvaluate);
                    paperToEvaluate.PublicationPendingArea.PublicationPending.Add(paperToEvaluate);
                }
                else
                {
                    paperToEvaluate.EvaluationPendingArea.EvaluationPending.Remove(paperToEvaluate) ;
                    paperToEvaluate.EvaluationPendingArea=null;
                }
                Commit();
            }
            throw new ServiceException("You do not have permissions to evaluate this paper.");
        }
        public bool isEvaluationPending(int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null) throw new ServiceException("Paper not found");
            return paper.EvaluationPendingArea != null;
        }

        public void AddCoAuthors(Person person, int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            List<Person> coAuthors = paper.CoAuthors.ToList();
            if (coAuthors.Count >= 4)
            {
                throw new ServiceException(resourceManager.GetString("MaximumNumberOfCoAuthors"));
            }
            coAuthors.Add(person);
            Commit();
        }

        public void PublishPaper(int paperId)
        {
            ValidateLoggedUser(true);
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            Paper paper = magazine.GetPaperById(paperId);
            //Check if the paper is pending of publication
            if (isPublicationPending(paperId))
            {
                Area pubPend = paper.PublicationPendingArea;
                pubPend.PublicationPending.Remove(paper);
                paper.PublicationPendingArea = null;
                int idIssue = BuildIssue();
                paper.Issue=magazine.GetIssueById(idIssue);
             }
            throw new ServiceException(resourceManager.GetString("PaperAlreadyPublished"));
        }


        //Checking that is published because the issue is not null
        public bool isPublishedPaper(int paperId) { 
            Paper paper = magazine.GetPaperById(paperId);
            return paper.Issue != null;
        }

        public void UnPublishPaper(int paperId) {
            ValidateLoggedUser(true);
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            //Check that the paper is published
            Paper paper = magazine.GetPaperById(paperId);
            if (paper.Issue!=null) //Cambiar por metodo de arriba <----
            {
                Area pubPend = paper.BelongingArea;
                paper.PublicationPendingArea = pubPend;
                pubPend.PublicationPending.Add(paper);
                paper.Issue.PublishedPapers.Remove(paper);
                paper.Issue = null;

            }
            throw new ServiceException(resourceManager.GetString("PaperNotPublished"));

        }


        public bool isPublicationPending(int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            return paper.PublicationPendingArea != null;
        }

        public bool isAccepted(int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            bool accepted = paper.Evaluation.Accepted;
            return accepted;
        }

        public List<Paper> ListAllPapers() 
        {
            ValidateLoggedUser(true);
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            //falta hacer la lsita con los papers
            List<Area> areas = magazine.Areas.ToList();
            List<Paper> allPapers = new List<Paper>();
            foreach(Area area in areas)
            {
                allPapers.Concat<Paper>(area.Papers);
            }
            return allPapers;
        }

        public List<Person> ListAllAuthors(Paper paper)
        {
            ValidateLoggedUser(true);
            if (!IsChiefEditor())
            {
                throw new ServiceException("User not allowed");
            }
            List<Person> allAuthors = new List<Person>();
            allAuthors.Add(paper.Responsible);
            allAuthors.Concat<Person>(paper.CoAuthors);
            return allAuthors;
        }


        //To list papers that are have pending their publication in an area
        public List<Paper> PendingPublicationPaper(Area area)
        {
            return area.PublicationPending.ToList<Paper>();
        }

        //To list papers that are published in an area
        public List<Paper> PublishedPapers(Area area)
        {
            List<Paper> pubPapers = new List<Paper>();
            foreach (Paper paper in area.Papers) 
            {
                if (isPublishedPaper(paper.Id))
                { 
                    pubPapers.Add(paper);
                }
            }
            return pubPapers;
        }

        public List<Paper> NoEvaluationPaper(Area area)
        {
            return area.EvaluationPending.ToList<Paper>();
        }

        public string GetState(int paperId)
        {
            Paper paper = magazine.GetPaperById(paperId);
            if (paper == null)
            {
                throw new ServiceException("Paper does not exist");
            }
            if (isEvaluationPending(paperId))
            {
                return "Pending Evaluation";
            }
            else if (isPublicationPending(paperId))
            {
                return "Pending Publication";
            }
            else if (isAccepted(paperId))
            {
                return "Is Accepted";
            }
            return "Is Rejected";
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
            if (magazine == null) throw new ServiceException(resourceManager.GetString("MagazineNotExists"));

            Issue issue = new Issue(number, magazine);
            magazine.Issues.Add(issue);
            Commit();
            return issue.Id;
        }

        public int BuildIssue()
        {
            List<Issue> issues = magazine.Issues.ToList<Issue>();
            int number = 0;
            foreach (Issue issue in issues)
            {
                number = issue.Number;
                if(issue.PublicationDate == null)
                {
                    return issue.Number;
                }
            }
            return AddIssue(number+1);
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
            if (loggedUser.Magazine==null) throw new ServiceException(resourceManager.GetString("InvalidAddAreaUser"));

            // validate magazine exists
            if (magazine == null) throw new ServiceException(resourceManager.GetString("MagazineNotExists"));

            // validate area name not empty
            if ((areaName == null)||(areaName.Length == 0)) throw new ServiceException(resourceManager.GetString("InvalidAreaName"));
            
            // validate not another area with same name
            if (magazine.GetAreaByName(areaName) != null) throw new ServiceException(resourceManager.GetString("InvalidAreaName"));
            
            // validate editor id not empty
            if ((editorId == null) || (editorId.Length == 0)) throw new ServiceException(resourceManager.GetString("NullUserId"));

            //validate editor exists
            var editor = dal.GetById<User>(editorId);
            if (editor==null) throw new ServiceException(resourceManager.GetString("UserNotExists"));            

            // inserts area
            Area area = new Area(areaName, editor, magazine);
            magazine.AddArea(area);
            Commit();
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
            if ((name == null)||(name.Equals(""))) throw new ServiceException(resourceManager.GetString("InvalidMagazineName"));            
            
            // validate chief editor id not empty
            if ((chiefEditorId==null)||(chiefEditorId.Length==0)) throw new ServiceException(resourceManager.GetString("NullUserId"));
            
            // validate chief editor exists
            var chief =dal.GetById<User>(chiefEditorId);
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

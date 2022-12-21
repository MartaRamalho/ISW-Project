using Magazine.Persistence;
using Magazine.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public virtual ICollection<Issue> Issues
        {
            get;
            set;
        }

        public virtual ICollection<Area> Areas
        {
            get;
            set;
        }
        [Required]
        public virtual User ChiefEditor
        {
            get;
            set;
        }

        public Area getAreaById(int id)
        {
            foreach (Area area in Areas)
            {
                if (area.Id == id) return area;
            }
            return null;
        }

        public Issue GetIssueById(int id)
        {
            foreach (Issue issue in Issues)
            {
                if (issue.Id == id) return issue;
            }
            return null;
        }

        public Issue GetIssueByNumber(int number)
        {
            foreach (Issue issue in Issues)
            {
                if (issue.Number == number) return issue;
            }
            return null;
        }

        public Area GetAreaByName(String name)
        {
            foreach (Area area in Areas)
            {
                if (area.Name == name) return area;
            }
            return null;
        }

        public void AddArea(Area area)
        {
            Areas.Add(area);
        }

        public Paper GetPaperById(int id)
        {
            foreach (Area area in Areas)
            {
                foreach (Paper paper in area.Papers)
                {
                    if (paper.Id == id) return paper;
                }
            }
            return null;
        }
        public ICollection<int> ListAllPapers()
        {
            ICollection<Area> areas = Areas.ToList();
            ICollection<int> allPapers = new List<int>();
            foreach (Area area in areas)
            {
                foreach (Paper paper in area.Papers)
                {
                    allPapers.Add(paper.Id);
                }
            }
            return allPapers;
        }
        public Issue AddIssue(int number)
        {
            Issue issue = new Issue(number, this);
            Issues.Add(issue);
            return issue;
        }
        public ICollection<int> ListAreas()
        {
            ICollection<int> areas = new List<int>();
            foreach (Area area in Areas)
            {
                areas.Add(area.Id);
            }
            return areas;
        }
        public ICollection<int> GetListIssues()
        {
            ICollection<int> issues = new List<int>();
            foreach (Issue issue in Issues)
            {
                issues.Add(issue.Id);
            }
            return issues;
        }
        public int PublishIssue(int number, DateTime date)
        {
            Issue issue = GetIssueByNumber(number);
            if (issue == null)
            {
                Issue newIssue = new Issue(number, this);
                newIssue.PublicationDate = date;
                Issues.Add(issue);
            }
            else
            {
                issue.PublicationDate = date;
            }
            return issue.Number;
        }
    }

    
}

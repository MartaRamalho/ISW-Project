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
        public List<Paper> ListAllPapers()
        {
            List<Area> areas = Areas.ToList();
            List<Paper> allPapers = new List<Paper>();
            foreach (Area area in areas)
            {
                allPapers.Concat(area.Papers);
            }
            return allPapers;
        }
        public int GetCurrentIssue()
        {
            int number = 0;
            foreach (Issue issue in Issues)
            {
                number = issue.Number;
                if (issue.PublicationDate == null)
                {
                    return number;
                }
            }
            return AddIssue(number+1).Number;
        }
        public Issue AddIssue(int number)
        {
            Issue issue = new Issue(number, this);
            Issues.Add(issue);
            return issue;
        }
        public ICollection<String> ListAreasByName()
        {
            ICollection<String> areas = new List<String>();
            foreach(Area area in Areas)
            {
                areas.Add(area.Name);
            }
            return areas;
        }
    }

    
}

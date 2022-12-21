using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public int Id
        {
            get;
            set;
        }

        public int Number
        {
            get;
            set;
        }

        public DateTime? PublicationDate
        {
            get;
            set;
        }

        public virtual Magazine Magazine
        {
            get;
            set;
        }

        public virtual ICollection<Paper> PublishedPapers
        {
            get;
            set;
        }

        public ICollection<int> GetPapers()
        {
            ICollection<int> papers = new List<int>();
            foreach (Paper paper in PublishedPapers)
            {
                papers.Add(paper.Id);
            }
            return papers;
        }
    }
}

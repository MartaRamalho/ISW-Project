using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public Issue()
        {
            PublishedPapers = new List<Paper>();
        }

        public Issue(int Number, Magazine Magazine) :this()
        {
            this.Magazine = Magazine;
            this.Number = Number;
            this.PublicationDate = PublicationDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public Paper()
        {
            this.CoAuthors = new List<Person>();
        }

        public Paper(String title, DateTime uploadDate, Area belongingArea, User responsible) : this()
        {
            // attributes
            this.Title = title;
            this.UploadDate = uploadDate;

            // person links
            this.CoAuthors.Add(Responsible);

            // area links
            this.BelongingArea = belongingArea;
            
            // user links
            this.Responsible = responsible;
            this.CoAuthors.Add(responsible);
        }
    }
}

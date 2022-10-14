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
            CoAuthors = new List<Person>();
        }

        public Paper(String title, DateTime uploadDate, Area belongingArea, User responsible) : this()
        {
            this.Title = title;
            this.BelongingArea = belongingArea;
            this.Responsible = responsible;
            this.UploadDate = uploadDate;
            CoAuthors.Add(Responsible);
        }
    }
}

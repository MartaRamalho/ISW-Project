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

        public Paper(String title, Area belongingArea, User responsible, DateTime uploadDate) : this()
        {
            this.Title = title;
            this.BelongingArea = belongingArea;
            this.Responsible = responsible;
            this.UploadDate = uploadDate;
        }
    }
}

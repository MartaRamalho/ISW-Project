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

        public Paper(String title, DateTime uploadDate, User responsible, Area belongingArea) : this()
        {
            this.Title = title;
            this.UploadDate = uploadDate;
            this.Responsible = responsible;
            this.BelongingArea = belongingArea;
        }
    }
}

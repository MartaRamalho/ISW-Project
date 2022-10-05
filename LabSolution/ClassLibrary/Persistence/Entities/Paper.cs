using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {

        // Attributes
        public int Id
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public DateTime UploadDate
        {
            get;
            set;
        }


        // Links and references to other classes
        public User Responsible
        {
            get;
            set;
        }

        public Area BelongingArea
        {
            get;
            set;
        }
        public Area ?EvaluationPendingArea
        {
            get;
            set;
        }

        public Area ?PublicationPendingArea
        {
            get;
            set;
        }

        public Issue ?Issue
        {
            get;
            set;
        }

        public Evaluation ?Evaluation
        {
            get;
            set;
        }

        public virtual ICollection<Person> CoAuthors
        {
            get;
            set;
        }
    }
}

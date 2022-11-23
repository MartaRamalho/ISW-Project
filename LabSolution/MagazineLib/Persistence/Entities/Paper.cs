using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        public virtual User Responsible
        {
            get;
            set;
        }
        [InverseProperty("Papers")]
        [Required]
        public virtual Area BelongingArea
        {
            get;
            set;
        }
        [InverseProperty("EvaluationPending")]
        public virtual Area EvaluationPendingArea
        {
            get;
            set;
        }
        [InverseProperty("PublicationPending")]
        public virtual Area PublicationPendingArea
        {
            get;
            set;
        }

        public virtual Issue Issue
        {
            get;
            set;
        }

        public virtual Evaluation Evaluation
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

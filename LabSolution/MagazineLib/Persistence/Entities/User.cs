using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    {
        public bool Alerted { get; set; }
        public String AreasOfInterest { get; set; }
        public String Email { get; set; }

        public String Login { get; set; }

        public String Password { get; set; }

        public virtual ICollection<Paper> MainAuthoredPapers
        {
            get;
            set;
        }

        public virtual Magazine Magazine
        {
            get;
            set;
        }

        public virtual Area Area
        {
            get;
            set;
        }

    }
}

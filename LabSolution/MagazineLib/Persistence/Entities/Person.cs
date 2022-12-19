using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        // Attributes
        public String Id
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String Surname
        {
            get;
            set;
        }

        // References to other classes
        public virtual ICollection<Paper> CoAuthoredPapers
        {
            get;
            set;
        }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
}

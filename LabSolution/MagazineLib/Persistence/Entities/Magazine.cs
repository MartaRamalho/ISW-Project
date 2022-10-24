using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        [InverseProperty("Magazine")]
        public virtual ICollection<Issue> Issues
        {
            get;
            set;
        }
        [InverseProperty("Magazine")]
        public virtual ICollection<Area> Areas
        {
            get;
            set;
        }
        [Required]
        public virtual User ChiefEditor
        {
            get;
            set;
        }
    }
}

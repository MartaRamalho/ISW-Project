using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine()
        {
            Issues = new List<Issue>();
            Areas = new List<Area>();
        }

        public Magazine(String Name, User ChiefEditor) :this()
        {
            this.ChiefEditor = ChiefEditor;
            this.Name = Name;
        }
    }
}

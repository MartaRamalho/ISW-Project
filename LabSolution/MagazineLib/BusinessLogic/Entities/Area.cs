using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {
        public Area()
        {
            EvaluationPending = new List<Paper>();
            PublicationPending = new List<Paper>();
            Papers = new List<Paper>();
        }
        public Area(string name, User editor, Magazine magazine):this()
        {
            this.Name = name;
            this.Editor = editor;
            this.Magazine = magazine;
        }
        
    }
}

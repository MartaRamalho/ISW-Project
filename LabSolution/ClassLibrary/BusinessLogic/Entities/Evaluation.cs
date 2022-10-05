using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public Evaluation() 
        { 
        
        }

        public Evaluation(bool accepted, string comments, DateTime dateTime, int id, Paper paper):this()
        {
            this.Accepted = accepted;
            this.Comments = comments;
            this.DateTime = dateTime;
            this.Id = id;
            this.Paper = paper;
        }
    }
}

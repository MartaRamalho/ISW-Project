﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public bool Accepted
        {
            get;
            set;
        }
        
        public string Comments 
        {
            get;
            set;
        }
        
        public DateTime Date
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

    }
}

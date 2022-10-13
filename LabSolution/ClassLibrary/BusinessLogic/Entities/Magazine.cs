﻿using System;
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

        public Magazine(User ChiefEditor, String Name):this()
        {
            this.ChiefEditor = ChiefEditor;
            this.Name = Name;
        }
    }
}

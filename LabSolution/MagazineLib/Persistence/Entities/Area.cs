﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
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
        [InverseProperty("BelongingArea")]
        public virtual ICollection<Paper> Papers
        {
            get;
            set;
        }
        [InverseProperty("EvaluationPendingArea")]
        public virtual ICollection<Paper> EvaluationPending
        {
            get;
            set;
        }
        [InverseProperty("PublicationPendingArea")]
        public virtual  ICollection<Paper> PublicationPending
        {
            get;
            set;
        }

        public virtual Magazine Magazine
        {
            get;
            set;
        }
        [Required]
        public virtual User Editor
        {
            get;
            set;
        }

        public void AddPaper(Paper paper)
        {
            Papers.Add(paper);
            EvaluationPending.Add(paper);
        }
        public void EvaluatePaper(Paper paper, bool accepted)
        {
            EvaluationPending.Remove(paper);
            if (accepted)
            {
                PublicationPending.Add(paper);
            }
        }

        public ICollection<int> GetPapersPendingEvaluation()
        {
            ICollection<int> result = new List<int>();
            foreach(Paper paper in EvaluationPending)
            {
                result.Add(paper.Id);
            }
            return result;
        }

        public ICollection<int> GetPapersPendingPublication()
        {
            ICollection<int> result = new List<int>();
            foreach (Paper paper in PublicationPending)
            {
                result.Add(paper.Id);
            }
            return result;
        }
    }
}

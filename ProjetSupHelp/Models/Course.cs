using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetSupHelp.Models
{
    public class Course
    {
        public enum SupinfoYear { ASc1 = 0 , ASc2 = 1, BSc3 = 2, MSc1 =3, MSc2 = 4 };

        [Key]
        public int Id { get; set; }

        [Required]
        public String Label { get; set; }

        public String Description { get; set; }

        public SupinfoYear Year { get; set; }

        public virtual ICollection<SupportProposition> SupportPropositions { get; set; }
        public virtual ICollection<SupportDemand> SupportDemand { get; set; }
    }   
}
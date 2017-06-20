using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetSupHelp.Models
{
    public class Campus
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string City { get; set; }

        public string Continent { get; set; }

        public virtual ICollection<SupportProposition> SupportPropositions { get; set; }
        public virtual ICollection<SupportDemand> SupportDemand { get; set; }
    }
}
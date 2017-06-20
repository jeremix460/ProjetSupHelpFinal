using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ProjetSupHelp.Models
{
    public class Availability
    {
        public int AvailabilityId { get; set; }

        public DayOfWeek Day { get; set; }

        public virtual ICollection<SupportProposition> SupportPropositions { get; set; }
        public virtual ICollection<SupportDemand> SupportDemand { get; set; }
    }
}
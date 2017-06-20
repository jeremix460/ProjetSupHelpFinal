using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ProjetSupHelp.Models
{
    public class SupportDemand
    {
        [Key]
        public long ID { get; set; }

        [Required]
        [DisplayName("Bosster ID")]
        public int BoosterID { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Informations complémentaires")]
        public string Comments { get; set; }

        [DisplayName("Publication")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modules")]
        public Course DemandedCourses { get; set; }

        [Required]
        [DisplayName("Campus")]
        public ICollection<Campus> Campus { get; set; }

        [Required]
        [DisplayName("Disponibilités")]
        public ICollection<Availability> Availabilities { get; set; }
    }
}
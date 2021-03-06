﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetSupHelp.Models
{
    public class SupportProposition
    {
        [Key]
        public long ID { get; set; }

        [Required]
        [DisplayName("Bosster ID")]
        public int BoosterID { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Autre(s) domaine(s)")]
        public string ExtraCourses { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Informations complémentaires")]
        public string Comments { get; set; }

        [DisplayName("Publication")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime CreationDate { get; set; }

        [Required]
        [DisplayName("Modules")]
        public ICollection<Course> SupportedCourses { get; set; }

        [Required]
        [DisplayName("Campus")]
        public ICollection<Campus> Campus { get; set; }

        [Required]
        [DisplayName("Disponibilités")]
        public ICollection<Availability> Availabilities { get; set; }
    }
}
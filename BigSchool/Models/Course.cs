using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BigSchool.Models
{
    public class Course
    {
        public int ID { get; set; }
        public bool IsCanceled { get; set; }
        public ApplicationUser Lecturer { get; set; }

        [StringLength(128)]
        public string LecturerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}
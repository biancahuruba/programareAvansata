using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCurs8.Models
{
    public class ProjectEvaluation

    {
        public int Id { get; set; }
        [StringLength(1000)]
        [Required]
        public string Name { get; set; }

        public string City { get; set; }
        public string Country { get; set; }

        [Range(1,10)]
        [Required]
        public double Rating { get; set; }
    }
}
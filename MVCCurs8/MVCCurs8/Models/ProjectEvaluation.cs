using MVCCurs8.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCurs8.Models
{
    [Bind(Exclude="Country")]
    public class ProjectEvaluation:IValidatableObject

    {
        public int Id { get; set; }
        [StringLength(1000)]
        [Required]
        [Display(Name="Descriere")]
        [MaxWords(3)]
        public string Description { get;  set; }
        public string Name { get; set; }

        public string City { get; set; }
        public string Country { get; set; }

        //[Range(1,10)]
        [Required]
        public double Rating { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Rating < 2 && Name.ToLower().StartsWith("john"))
        //    { yield return new ValidationResult("Sorry John, you can’t do this"); }

        //}

        //Tema
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            if (Rating > 10 || Rating < 0) {
                yield return new ValidationResult("The Rating must be between 0 and 10!");
            }
        }
    }
}
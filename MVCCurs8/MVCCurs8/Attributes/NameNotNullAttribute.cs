using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCurs8.Attributes
{
    public class NameNotNullAttribute: System.ComponentModel.DataAnnotations.ValidationAttribute
    {
       
        public NameNotNullAttribute() : base("{0} has to have at least one word.")
        {
           
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
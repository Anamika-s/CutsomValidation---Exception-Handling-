using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeWithValidation.Models
{
    public class MoreThanCurrentDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime obj = (DateTime)value;
                if (obj > DateTime.UtcNow)
                    return ValidationResult.Success;
            }
         return new ValidationResult(ErrorMessage ?? "Date of Joining >= than today");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeWithValidation.Models
{
    public class CheckDateRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int age = (int)value;
                if (age > 20)
                {
                    return ValidationResult.Success;
                }
            }

            
            return new ValidationResult(ErrorMessage ?? "Age should be more than 20");

            }

        }
    }


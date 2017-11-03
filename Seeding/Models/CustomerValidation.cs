using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seeding.Models
{
    public class CustomerValidation:ValidationAttribute
    {

        protected override ValidationResult IsValid (object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var t = Convert.ToString(value).Length;
                if (t < 20)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Location should be leass than 20 characters");
                }
            }
            else
            {
                return new ValidationResult("Pease enter Location"); }
        }
    }
}
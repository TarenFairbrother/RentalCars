using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Models.ValidationAttributes
{
   public  class Rental_EnsureEndDateAfterStartDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var rental = validationContext.ObjectInstance as Rental;
            if (rental.ReturnDate < rental.StartDate)
                return new ValidationResult("End date must be after start date");

            return ValidationResult.Success;
        }
    }
}

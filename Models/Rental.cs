using RentalCars.Models.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Models
{
   public class Rental
    {
        [Key]
        public int RentalId { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        [Required]
        [Rental_EnsureEndDateAfterStartDate]
        public DateTime? ReturnDate { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string PostalCode { get; set; }
        public string Status { get; set; }
        public double TotalPrice { get; set; }
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public Car Car { get; set; }


    }
}

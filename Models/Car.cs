using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Models
{
   public class Car
    {
        [Required]
        public int CarId { get; set; }
        public int? RentalId { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Kilometers { get; set; }
        public string LicensePlaceNumber { get; set; }
        public string ImageUrl { get; set; }
        public double RentalPrice { get; set; }
        public bool Rented { get; set; }
        public bool featured { get; set; }
        public Rental Rental { get; set; }

    }
}

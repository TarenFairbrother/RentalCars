using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Models;
using RentalCars.WebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalCars.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private readonly IRentalCarsDbRepository rentalCarRepo;

        public RentalsController(IRentalCarsDbRepository rentalCarRepo)
        {
            this.rentalCarRepo = rentalCarRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetRentals()
        {
            var rentals = await rentalCarRepo.GetRentals();
            return Ok(rentals);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var rental = await rentalCarRepo.GetRentalById(id);
            if (rental == null)
                return NotFound();

            return Ok(rental);
        }
        [HttpPost]
        public async Task<IActionResult> AddRental([FromBody] Rental rental)
        {
            if (rental == null)
                return BadRequest("Rental is empty");

            await rentalCarRepo.AddRental(rental);

            return CreatedAtAction(nameof(GetById),
                new { id = rental.RentalId },
                rental
                );
        }

    }
}

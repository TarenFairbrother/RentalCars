using Microsoft.AspNetCore.Mvc;
using RentalCars.Models;
using RentalCars.WebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalCars.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly IRentalCarsDbRepository rentalCarRepo;

        public CarsController(IRentalCarsDbRepository rentalCarRepo)
        {
            this.rentalCarRepo = rentalCarRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var cars = await rentalCarRepo.GetCars();

            return Ok(cars);
        }

        [HttpGet]
        [Route("/api/featuredcars")]
        public async Task<IActionResult> GetFeaturedCars()
        {
            var featuredCars = await rentalCarRepo.GetFeaturedCars();

            return Ok(featuredCars);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var car = await rentalCarRepo.GetCarById(id);
            if (car == null)
                return NotFound();

            return Ok(car);
        }

        [HttpGet]
        [Route("/api/cars/brand/{brand}")]
        public async Task<IActionResult> GetByBrand(string brand)
        {
            var cars = await rentalCarRepo.GetCarsByBrand(brand);
            if (cars == null)
                return NotFound();

            return Ok(cars);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewRentalCar([FromBody] Car car)
        {
            if (car == null)
                return NoContent();

            await rentalCarRepo.AddNewRentalCar(car);

            return CreatedAtAction(nameof(GetById),
                new { id = car.CarId },
                car
                );
        }
    }


}

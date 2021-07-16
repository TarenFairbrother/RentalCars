using DataStoreEF;
using Microsoft.EntityFrameworkCore;
using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.WebAPI.Repository
{
    public class RentalCarsDbRepository : IRentalCarsDbRepository
    {
        private readonly RentalCarsDbContext db;

        public RentalCarsDbRepository(RentalCarsDbContext db)
        {
            this.db = db;
        }
        #region Cars db calls

        public async Task<List<Car>> GetCars()
        {
            return await db.Cars.ToListAsync();
        }

        public async Task<Car> GetCarById(int carId)
        {
            return await db.Cars.FindAsync(carId);
        }

        public async Task<List<Car>> GetFeaturedCars()
        {
            return await db.Cars.Where(x => x.featured == true).ToListAsync();
        }

        public async Task<List<Car>> GetCarsByBrand(string brand)
        {
            return await db.Cars.Where(x => x.Brand.ToLower().Contains(brand.ToLower())).ToListAsync();
        }

        public async Task AddNewRentalCar(Car car)
        {
            await db.Cars.AddAsync(car);
            await db.SaveChangesAsync();
        }
        #endregion

        #region Rentals db calls

        public async Task<List<Rental>> GetRentals()
        {
            return await db.Rentals.ToListAsync();
        }

        public async Task<Rental> GetRentalById(int rentalId)
        {
            return await db.Rentals.FindAsync(rentalId);
        }

        public async Task AddRental(Rental rental)
        {
            await db.Rentals.AddAsync(rental);
            await db.SaveChangesAsync();
        }

        #endregion

    }
}

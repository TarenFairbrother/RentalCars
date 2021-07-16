using RentalCars.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RentalCars.WebApp.Repository
{
    public interface IWebApiRepository
    {
        Task AddNewCar(Car car);
        Task AddNewRental(Rental rental);
        Task<List<Car>> GetCarByBrand(string brand);
        Task<Car> GetCarById(int carId);
        public Task<List<Car>> GetCars();
        Task<List<Car>> GetFeaturedCars();
        Task<Rental> GetRentalById(int rentalId);
        Task<List<Rental>> GetRentals();
    }
}
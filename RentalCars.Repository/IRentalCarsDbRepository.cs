using RentalCars.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RentalCars.WebAPI.Repository
{
    public interface IRentalCarsDbRepository
    {
        Task AddNewRentalCar(Car car);
        Task AddRental(Rental rental);
        Task<Car> GetCarById(int carId);
        Task<List<Car>> GetCars();
        Task<List<Car>> GetCarsByBrand(string brand);
        Task<List<Car>> GetFeaturedCars();
        Task<Rental> GetRentalById(int rentalId);
        Task<List<Rental>> GetRentals();
    }
}
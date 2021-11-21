using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.WebApp.Repository
{
    public class WebApiRepository : IWebApiRepository
    {
        private readonly HttpClient httpClient;
        private string baseURl = "https://localhost:44309/api/";

        public WebApiRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Car>> GetCars()
        {
            return await httpClient.GetFromJsonAsync<List<Car>>(baseURl + "Cars");
        }

        public async Task<List<Car>> GetFeaturedCars()
        {
            return await httpClient.GetFromJsonAsync<List<Car>>(baseURl + "featuredcars");
        }

        public async Task<Car> GetCarById(int carId)
        {
            return await httpClient.GetFromJsonAsync<Car>(baseURl + $"Cars/{carId}");
        }

        public async Task<List<Car>> GetCarByBrand(string brand)
        {
            return await httpClient.GetFromJsonAsync<List<Car>>(baseURl + $"cars/brand/{brand}");
        }

        public async Task UpdateCar(int carId, Car car)
        {
            var response = await httpClient.PutAsJsonAsync(baseURl + $"Cars/{carId}", car );
            await HandleError(response);
        }

        public async Task AddNewCar(Car car)
        {
            var response = await httpClient.PostAsJsonAsync(baseURl + "Cars", car);
            await HandleError(response);
        }

        public async Task<List<Rental>> GetRentals()
        {
            return await httpClient.GetFromJsonAsync<List<Rental>>(baseURl + "Rentals");
        }

        public async Task<Rental> GetRentalById(int rentalId)
        {
            return await httpClient.GetFromJsonAsync<Rental>(baseURl + $"Rentals/{rentalId}");
        }

        public async Task AddNewRental(Rental rental)
        {
            var response = await httpClient.PostAsJsonAsync(baseURl + "Rentals", rental);
            await HandleError(response);
        }

        public async Task HandleError(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(error);
            }
        }
    }
}

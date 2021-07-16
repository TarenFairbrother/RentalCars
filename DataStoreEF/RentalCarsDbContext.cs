using Microsoft.EntityFrameworkCore;
using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStoreEF
{
    public class RentalCarsDbContext : DbContext
    {
        public RentalCarsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Rental>()
                 .HasOne(c => c.Car)
                .WithOne(r => r.Rental)
                .HasForeignKey<Car>(t => t.RentalId);
                

            modelBuilder.Entity<Car>().HasData(

                new Car
                {
                    CarId = 1,
                    Brand = "Honda",
                    Model = "Civic",
                    Make = "2 Door",
                    Year = 2012,
                    Color = "Blue",
                    Description = "The front-wheel-drive 2012 Civic has a 1.8-liter four-cylinder engine with 140 horsepower." +
                    " A five-speed manual transmission comes standard, and a five-speed automatic transmission is available. " +
                    "The engine is refined and it provides the Civic with adequate power around town and at highway speeds.",
                    Kilometers = 80000,
                    LicensePlaceNumber = "172IQX",
                    Rented = false,
                    RentalPrice = 199,
                    ImageUrl = "CarImages/2012 Honda Civic.jpg",
                    featured = true
                },

                new Car
                {
                    CarId = 2,
                    Brand = "Kia",
                    Model = "Forte",
                    Make = "4 Door",
                    Year = 2010,
                    Color = "Grey",
                    Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                    Kilometers = 55000,
                    LicensePlaceNumber = "1Y3XZ6",
                    Rented = true,
                    RentalPrice = 149.99,
                    ImageUrl = "CarImages/2010_kia_forte.webp",
                    featured = true
                },
                 new Car
                 {
                     CarId = 3,
                     Brand = "Ford",
                     Model = "Explorer",
                     Make = "4 Door",
                     Year = 2010,
                     Color = "Black",
                     Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                     Kilometers = 57000,
                     LicensePlaceNumber = "1Y3XU8",
                     Rented = true,
                     RentalPrice = 139,
                     ImageUrl = "https://media.ed.edmunds-media.com/honda/civic/2021/oem/2021_honda_civic_4dr-hatchback_lx_fq_oem_1_815.jpg",
                     featured = true
                 },
                  new Car
                  {
                      CarId = 4,
                      Brand = "Honda",
                      Model = "Accord",
                      Make = "2 Door",
                      Year = 2015,
                      Color = "Red",
                      Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                      Kilometers = 42000,
                      LicensePlaceNumber = "1Y3YI9",
                      Rented = false,
                      RentalPrice = 429,
                      ImageUrl = "https://media.ed.edmunds-media.com/honda/civic/2021/oem/2021_honda_civic_4dr-hatchback_lx_fq_oem_1_815.jpg",
                      featured = true
                  },
                   new Car
                   {
                       CarId = 5,
                       Brand = "Hyundia",
                       Model = "Elantra",
                       Make = "4 Door",
                       Year = 2021,
                       Color = "Blue",
                       Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                       Kilometers = 20000,
                       LicensePlaceNumber = "1Y3FG4",
                       Rented = true,
                       RentalPrice = 249,
                       ImageUrl = "https://media.ed.edmunds-media.com/honda/civic/2021/oem/2021_honda_civic_4dr-hatchback_lx_fq_oem_1_815.jpg",
                       featured = true
                   },
                   new Car
                   {
                       CarId = 6,
                       Brand = "Honda",
                       Model = "Accord",
                       Make = "2 Door",
                       Year = 2015,
                       Color = "Red",
                       Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                       Kilometers = 42000,
                       LicensePlaceNumber = "1Y3YI9",
                       Rented = false,
                       RentalPrice = 429,
                       ImageUrl = "https://media.ed.edmunds-media.com/honda/civic/2021/oem/2021_honda_civic_4dr-hatchback_lx_fq_oem_1_815.jpg",
                       featured = true
                   },
                   new Car
                   {
                       CarId = 7,
                       Brand = "Honda",
                       Model = "Accord",
                       Make = "2 Door",
                       Year = 2015,
                       Color = "Red",
                       Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                       Kilometers = 42000,
                       LicensePlaceNumber = "1Y3YI9",
                       Rented = false,
                       RentalPrice = 429,
                       ImageUrl = "https://media.ed.edmunds-media.com/honda/civic/2021/oem/2021_honda_civic_4dr-hatchback_lx_fq_oem_1_815.jpg"
                   },
                   new Car
                   {
                       CarId = 8,
                       Brand = "Honda",
                       Model = "Accord",
                       Make = "2 Door",
                       Year = 2015,
                       Color = "Red",
                       Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                       Kilometers = 42000,
                       LicensePlaceNumber = "1Y3YI9",
                       Rented = false,
                       RentalPrice = 429,
                       ImageUrl = "https://media.ed.edmunds-media.com/honda/civic/2021/oem/2021_honda_civic_4dr-hatchback_lx_fq_oem_1_815.jpg"
                   },
                   new Car
                   {
                       CarId = 9,
                       Brand = "Honda",
                       Model = "Accord",
                       Make = "2 Door",
                       Year = 2015,
                       Color = "Red",
                       Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                       Kilometers = 42000,
                       LicensePlaceNumber = "1Y3YI9",
                       Rented = false,
                       RentalPrice = 429,
                       ImageUrl = "https://media.ed.edmunds-media.com/honda/civic/2021/oem/2021_honda_civic_4dr-hatchback_lx_fq_oem_1_815.jpg"
                   },
                   new Car
                   {
                       CarId = 10,
                       Brand = "Honda",
                       Model = "Accord",
                       Make = "2 Door",
                       Year = 2015,
                       Color = "Red",
                       Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                       Kilometers = 42000,
                       LicensePlaceNumber = "1Y3YI9",
                       Rented = false,
                       RentalPrice = 429,
                       ImageUrl = "https://media.ed.edmunds-media.com/honda/civic/2021/oem/2021_honda_civic_4dr-hatchback_lx_fq_oem_1_815.jpg"
                   },
                   new Car
                   {
                       CarId = 11,
                       Brand = "Honda",
                       Model = "Accord",
                       Make = "2 Door",
                       Year = 2015,
                       Color = "Red",
                       Description = "The Kia Forte, known as the K3 in South Korea, the Forte K3 or Shuma in China and Cerato in South America, Australia and New Zealand, is a compact car manufactured by Korean automaker Kia since mid-2008, replacing the Kia Cerato/Spectra. " +
                    "It is available in two-door coupe, four-door sedan, five-door hatchback variants. It is not available in Europe, where the similar sized Kia Ceed is offered (except for Russia and Ukraine, where the Ceed and the Forte are both available).",
                       Kilometers = 42000,
                       LicensePlaceNumber = "1Y3YI9",
                       Rented = false,
                       RentalPrice = 429,
                       ImageUrl = "https://media.ed.edmunds-media.com/honda/civic/2021/oem/2021_honda_civic_4dr-hatchback_lx_fq_oem_1_815.jpg"
                   }); ;
        }
    }
}

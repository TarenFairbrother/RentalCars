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

    }
}

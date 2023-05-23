using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataContext
{

    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        // Add DbSet properties for other entities

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings and relationships here
            // Example: modelBuilder.Entity<Car>().HasKey(c => c.CarId);
            // Example: modelBuilder.Entity<Car>().HasMany(c => c.Rentals).WithOne(r => r.Car);

            base.OnModelCreating(modelBuilder);
        }
    }
}

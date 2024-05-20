using Band.Models;
using Microsoft.EntityFrameworkCore;

namespace Band.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TourEvent> TourEvent { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Clothing", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Accessories", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Media", DisplayOrder = 3 }       
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "T-Shirt",
                    Description = "Black T-Shirt with a band logo on front and back.",
                    Price = 50
                },
                new Product
                {
                    Id = 2,
                    Name = "Hoodie",
                    Description = "Long Sleeve Hoodie with Band logo on front and back.",
                    Price = 80
                },
                new Product
                {
                    Id = 3,
                    Name = "Cap",
                    Description = "Trucker style cap with band logo on the front.",
                    Price = 20
                },
                new Product
                {
                    Id = 4,
                    Name = "CD Album",
                    Description = "Album in CD format.",
                    Price = 15
                }
                );

            modelBuilder.Entity<TourEvent>().HasData(
                new TourEvent
                {
                    Id=1,
                    Date = new DateOnly(2024, 6, 10),
                    Time = new TimeOnly(19, 00),
                    Venue = "Madison Square Garden",
                    Country = "USA",
                    City = "New York"


                },
                new TourEvent
                {
                    Id = 2,
                    Date = new DateOnly(2024, 7, 15),
                    Time = new TimeOnly(19, 00),
                    Venue = "The O2 Arena",
                    Country = "UK",
                    City = "London"
                },
                new TourEvent
                {
                    Id = 3,
                    Date = new DateOnly(2024, 8, 20),
                    Time = new TimeOnly(19, 00),
                    Venue = "AccorHotels Arena",
                    Country = "France",
                    City = "Paris"
                },
                new TourEvent
                {
                    Id = 4,
                    Date = new DateOnly(2024, 9, 5),
                    Time = new TimeOnly(19, 00),
                    Venue = "Olympiahalle",
                    Country = "Germany",
                    City = "Munich"
                },
                new TourEvent
                {
                    Id = 5,
                    Date = new DateOnly(2024, 9, 12),
                    Time = new TimeOnly(19,00),
                    Venue = "Ziggo Dome",
                    Country = "Netherlands",
                    City = "Amsterdam"
                }
                );
        }
    }
}

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
                    Price = 50,
                    SKU = "B49L4LD9CI",
                    CategoryID = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Name = "Hoodie",
                    Description = "Long Sleeve Hoodie with Band logo on front and back.",
                    Price = 80,
                    SKU = "4YGKW1KCNL",
                    CategoryID = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "Cap",
                    Description = "Trucker style cap with band logo on the front.",
                    Price = 20,
                    SKU = "3FZL5VGCLQ",
                    CategoryID = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Name = "CD Album",
                    Description = "Album in CD format.",
                    Price = 15,
                    SKU = "D6RHWVQIPJ",
                    CategoryID = 3,
                    ImageUrl = ""
                }
                );

            modelBuilder.Entity<TourEvent>().HasData(
                new TourEvent
                {
                    Id=1,
                    Date = new DateTime(2024, 6, 10),
                    Venue = "Madison Square Garden",
                    Country = "USA",
                    City = "New York"


                },
                new TourEvent
                {
                    Id = 2,
                    Date = new DateTime(2024, 7, 15),
                    Venue = "The O2 Arena",
                    Country = "UK",
                    City = "London"
                },
                new TourEvent
                {
                    Id = 3,
                    Date = new DateTime(2024, 8, 20),
                    Venue = "AccorHotels Arena",
                    Country = "France",
                    City = "Paris"
                },
                new TourEvent
                {
                    Id = 4,
                    Date = new DateTime(2024, 9, 5),
                    Venue = "Olympiahalle",
                    Country = "Germany",
                    City = "Munich"
                },
                new TourEvent
                {
                    Id = 5,
                    Date = new DateTime(2024, 9, 12),
                    Venue = "Ziggo Dome",
                    Country = "Netherlands",
                    City = "Amsterdam"
                }
                );
        }
    }
}

﻿// <auto-generated />
using System;
using Band.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Band.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Band.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Media"
                        });
                });

            modelBuilder.Entity("Band.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Black T-Shirt with a band logo on front and back.",
                            Name = "T-Shirt",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Long Sleeve Hoodie with Band logo on front and back.",
                            Name = "Hoodie",
                            Price = 80.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Trucker style cap with band logo on the front.",
                            Name = "Cap",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "Album in CD format.",
                            Name = "CD Album",
                            Price = 15.0
                        });
                });

            modelBuilder.Entity("Band.Models.TourEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TourEvent");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "New York",
                            Country = "USA",
                            Date = new DateOnly(2024, 6, 10),
                            Time = new TimeOnly(19, 0, 0),
                            Venue = "Madison Square Garden"
                        },
                        new
                        {
                            Id = 2,
                            City = "London",
                            Country = "UK",
                            Date = new DateOnly(2024, 7, 15),
                            Time = new TimeOnly(19, 0, 0),
                            Venue = "The O2 Arena"
                        },
                        new
                        {
                            Id = 3,
                            City = "Paris",
                            Country = "France",
                            Date = new DateOnly(2024, 8, 20),
                            Time = new TimeOnly(19, 0, 0),
                            Venue = "AccorHotels Arena"
                        },
                        new
                        {
                            Id = 4,
                            City = "Munich",
                            Country = "Germany",
                            Date = new DateOnly(2024, 9, 5),
                            Time = new TimeOnly(19, 0, 0),
                            Venue = "Olympiahalle"
                        },
                        new
                        {
                            Id = 5,
                            City = "Amsterdam",
                            Country = "Netherlands",
                            Date = new DateOnly(2024, 9, 12),
                            Time = new TimeOnly(19, 0, 0),
                            Venue = "Ziggo Dome"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

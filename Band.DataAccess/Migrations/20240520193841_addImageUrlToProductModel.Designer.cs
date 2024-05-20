﻿// <auto-generated />
using System;
using Band.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Band.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240520193841_addImageUrlToProductModel")]
    partial class addImageUrlToProductModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryID = 1,
                            Description = "Black T-Shirt with a band logo on front and back.",
                            ImageUrl = "",
                            Name = "T-Shirt",
                            Price = 50.0,
                            SKU = "B49L4LD9CI"
                        },
                        new
                        {
                            Id = 2,
                            CategoryID = 1,
                            Description = "Long Sleeve Hoodie with Band logo on front and back.",
                            ImageUrl = "",
                            Name = "Hoodie",
                            Price = 80.0,
                            SKU = "4YGKW1KCNL"
                        },
                        new
                        {
                            Id = 3,
                            CategoryID = 1,
                            Description = "Trucker style cap with band logo on the front.",
                            ImageUrl = "",
                            Name = "Cap",
                            Price = 20.0,
                            SKU = "3FZL5VGCLQ"
                        },
                        new
                        {
                            Id = 4,
                            CategoryID = 3,
                            Description = "Album in CD format.",
                            ImageUrl = "",
                            Name = "CD Album",
                            Price = 15.0,
                            SKU = "D6RHWVQIPJ"
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

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

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
                            Date = new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Venue = "Madison Square Garden"
                        },
                        new
                        {
                            Id = 2,
                            City = "London",
                            Country = "UK",
                            Date = new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Venue = "The O2 Arena"
                        },
                        new
                        {
                            Id = 3,
                            City = "Paris",
                            Country = "France",
                            Date = new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Venue = "AccorHotels Arena"
                        },
                        new
                        {
                            Id = 4,
                            City = "Munich",
                            Country = "Germany",
                            Date = new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Venue = "Olympiahalle"
                        },
                        new
                        {
                            Id = 5,
                            City = "Amsterdam",
                            Country = "Netherlands",
                            Date = new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Venue = "Ziggo Dome"
                        });
                });

            modelBuilder.Entity("Band.Models.Product", b =>
                {
                    b.HasOne("Band.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

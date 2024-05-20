using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Band.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreTourEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TourEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourEvent", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TourEvent",
                columns: new[] { "Id", "City", "Country", "Date", "Venue" },
                values: new object[,]
                {
                    { 1, "New York", "USA", new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison Square Garden" },
                    { 2, "London", "UK", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The O2 Arena" },
                    { 3, "Paris", "France", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "AccorHotels Arena" },
                    { 4, "Munich", "Germany", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olympiahalle" },
                    { 5, "Amsterdam", "Netherlands", new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziggo Dome" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TourEvent");
        }
    }
}

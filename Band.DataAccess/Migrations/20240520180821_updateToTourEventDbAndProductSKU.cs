using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Band.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateToTourEventDbAndProductSKU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "TourEvent");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "TourEvent",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "SKU",
                value: "B49L4LD9CI");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "SKU",
                value: "4YGKW1KCNL");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "SKU",
                value: "3FZL5VGCLQ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "SKU",
                value: "D6RHWVQIPJ");

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Products");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "TourEvent",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Time",
                table: "TourEvent",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 6, 10), new TimeOnly(19, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 7, 15), new TimeOnly(19, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 8, 20), new TimeOnly(19, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 9, 5), new TimeOnly(19, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TourEvent",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 9, 12), new TimeOnly(19, 0, 0) });
        }
    }
}

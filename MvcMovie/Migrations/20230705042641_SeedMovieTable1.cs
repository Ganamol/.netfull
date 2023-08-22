using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class SeedMovieTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 5, 9, 56, 41, 195, DateTimeKind.Local).AddTicks(9020));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 1, 16, 47, 42, 774, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[] { 102, "KBV", 29, new DateTime(2023, 7, 1, 16, 47, 42, 776, DateTimeKind.Local).AddTicks(9059), "Manichithrathazhu" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[] { 101, "jayan", 29, new DateTime(2023, 7, 1, 16, 47, 42, 776, DateTimeKind.Local).AddTicks(9015), "theeram" });
        }
    }
}

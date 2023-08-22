using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class AlterMovieseedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 5, 10, 9, 11, 370, DateTimeKind.Local).AddTicks(1334));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 100,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 5, 9, 56, 41, 195, DateTimeKind.Local).AddTicks(9020));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboratorioDeTestesAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedInicitalCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Fusca" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Gol" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Civic" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Corolla" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Uno" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Palio" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "HB20" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Onix" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Cruze" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Fiesta" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));
        }
    }
}

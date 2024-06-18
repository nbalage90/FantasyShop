using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"), "[\"White Appliances\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-3.png", "Huawei Plus", 650.00m },
                    { new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"), "[\"Smart Phone\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-1.png", "IPhone X", 950.00m },
                    { new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"), "[\"White Appliances\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-4.png", "Xiaomi Mi 9", 470.00m },
                    { new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"), "[\"Camera\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-6.png", "Panasonic Lumix", 240.00m },
                    { new Guid("b786103d-c621-4f5a-b498-23452610f88c"), "[\"Smart Phone\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-5.png", "HTC U11+ Plus", 380.00m },
                    { new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"), "[\"Home Kitchen\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-6.png", "LG G7 ThinQ", 240.00m },
                    { new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"), "[\"Smart Phone\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-2.png", "Samsung 10", 840.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b786103d-c621-4f5a-b498-23452610f88c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"));
        }
    }
}

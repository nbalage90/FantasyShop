using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductIds = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ProductIds" },
                values: new object[,]
                {
                    { new Guid("2ecfc1fa-f6e6-4109-9afd-369d688eab2c"), "Smart Phone", "[\"5334c996-8457-4cf0-815c-ed2b77c4ff61\",\"c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914\",\"b786103d-c621-4f5a-b498-23452610f88c\"]" },
                    { new Guid("3152d35d-2053-4fed-9537-e579a81b3edc"), "Home Kitchen", "[\"c4bbc4a2-4555-45d8-97cc-2a99b2167bff\"]" },
                    { new Guid("91bd64b0-e908-4116-af04-67ef646e3dd2"), "White Appliances", "[\"4f136e9f-ff8c-4c1f-9a33-d12f689bdab8\",\"6ec1297b-ec0a-4aa1-be25-6726e3b51a27\"]" },
                    { new Guid("aad89c78-ae56-4692-aaf0-0dc0c3d3ed22"), "Camera", "[\"93170c85-7795-489c-8e8f-7dcf3b4f4188\"]" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryIds", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"), "[\"91bd64b0-e908-4116-af04-67ef646e3dd2\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-3.png", "Huawei Plus", 650.00m },
                    { new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"), "[\"2ecfc1fa-f6e6-4109-9afd-369d688eab2c\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-1.png", "IPhone X", 950.00m },
                    { new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"), "[\"91bd64b0-e908-4116-af04-67ef646e3dd2\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-4.png", "Xiaomi Mi 9", 470.00m },
                    { new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"), "[\"aad89c78-ae56-4692-aaf0-0dc0c3d3ed22\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-6.png", "Panasonic Lumix", 240.00m },
                    { new Guid("b786103d-c621-4f5a-b498-23452610f88c"), "[\"2ecfc1fa-f6e6-4109-9afd-369d688eab2c\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-5.png", "HTC U11+ Plus", 380.00m },
                    { new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"), "[\"3152d35d-2053-4fed-9537-e579a81b3edc\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-6.png", "LG G7 ThinQ", 240.00m },
                    { new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"), "[\"2ecfc1fa-f6e6-4109-9afd-369d688eab2c\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-2.png", "Samsung 10", 840.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

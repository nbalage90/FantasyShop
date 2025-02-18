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
                name: "CategoryProducts",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProducts", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CategoryProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ProductIds" },
                values: new object[,]
                {
                    { new Guid("56efbf6a-5501-4372-a646-55d7f9e257a9"), "Smart Phone", "[\"5334c996-8457-4cf0-815c-ed2b77c4ff61\",\"c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914\",\"b786103d-c621-4f5a-b498-23452610f88c\"]" },
                    { new Guid("80d73b9b-4597-4eab-8fe1-831ce1516b44"), "Home Kitchen", "[\"c4bbc4a2-4555-45d8-97cc-2a99b2167bff\"]" },
                    { new Guid("bb038599-cb6b-4d3c-96ed-442d655671a7"), "White Appliances", "[\"4f136e9f-ff8c-4c1f-9a33-d12f689bdab8\",\"6ec1297b-ec0a-4aa1-be25-6726e3b51a27\"]" },
                    { new Guid("c893511c-5c55-4f84-8ff4-5b2abf8912cb"), "Camera", "[\"93170c85-7795-489c-8e8f-7dcf3b4f4188\"]" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryIds", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"), "[\"bb038599-cb6b-4d3c-96ed-442d655671a7\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-3.png", "Huawei Plus", 650.00m },
                    { new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"), "[\"56efbf6a-5501-4372-a646-55d7f9e257a9\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-1.png", "IPhone X", 950.00m },
                    { new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"), "[\"bb038599-cb6b-4d3c-96ed-442d655671a7\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-4.png", "Xiaomi Mi 9", 470.00m },
                    { new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"), "[\"c893511c-5c55-4f84-8ff4-5b2abf8912cb\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-6.png", "Panasonic Lumix", 240.00m },
                    { new Guid("b786103d-c621-4f5a-b498-23452610f88c"), "[\"56efbf6a-5501-4372-a646-55d7f9e257a9\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-5.png", "HTC U11+ Plus", 380.00m },
                    { new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"), "[\"80d73b9b-4597-4eab-8fe1-831ce1516b44\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-6.png", "LG G7 ThinQ", 240.00m },
                    { new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"), "[\"56efbf6a-5501-4372-a646-55d7f9e257a9\"]", "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.", "product-2.png", "Samsung 10", 840.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProducts_ProductId",
                table: "CategoryProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProducts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

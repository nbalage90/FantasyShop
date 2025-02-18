using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08bee5bb-d58e-4e6d-be7f-617eb463d3a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48cc1eb7-33f5-4a68-91a9-b982f14fa8c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("618fd955-b75c-41b8-a7c2-82d25865498b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86e8b44b-337a-48ae-8b84-7ee4bdfa3e29"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("4abfe40d-6e05-4265-9ebe-0ed328bb4b75"), new Guid("1dfc07f8-cf7a-4942-b1ae-7e4ecaeeeb89") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("4abfe40d-6e05-4265-9ebe-0ed328bb4b75"), new Guid("e269c007-202f-4a0f-94a0-efdb3e7878f6") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("8d1027b6-e0e5-4c7f-8d8a-054fd72122f0"), new Guid("0a03166d-27e9-4b13-ba89-e6ad1fc3b32a") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("8d1027b6-e0e5-4c7f-8d8a-054fd72122f0"), new Guid("b9d02f70-50cf-4246-a3e8-c2bb3f8f4835") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("f81d9997-fcd4-4834-9937-7350f3d0316d"), new Guid("b9d539c4-7977-45eb-b5b4-5f0d554290b7") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("f81d9997-fcd4-4834-9937-7350f3d0316d"), new Guid("bc6c4ba1-62e0-44be-8cca-e4ee81318f69") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4abfe40d-6e05-4265-9ebe-0ed328bb4b75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d1027b6-e0e5-4c7f-8d8a-054fd72122f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f81d9997-fcd4-4834-9937-7350f3d0316d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a03166d-27e9-4b13-ba89-e6ad1fc3b32a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dfc07f8-cf7a-4942-b1ae-7e4ecaeeeb89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9d02f70-50cf-4246-a3e8-c2bb3f8f4835"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9d539c4-7977-45eb-b5b4-5f0d554290b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc6c4ba1-62e0-44be-8cca-e4ee81318f69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e269c007-202f-4a0f-94a0-efdb3e7878f6"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ProductIds" },
                values: new object[,]
                {
                    { new Guid("04bb54af-5207-43ec-8541-4d4aecc1b280"), "White Appliances", "[\"4f136e9f-ff8c-4c1f-9a33-d12f689bdab8\",\"6ec1297b-ec0a-4aa1-be25-6726e3b51a27\"]" },
                    { new Guid("1f325c6d-56a6-4e04-82f6-269e05fb598f"), "Groceries", "[]" },
                    { new Guid("42dad73a-4745-4c24-b423-d0d880d804f7"), "Smart Phone", "[\"5334c996-8457-4cf0-815c-ed2b77c4ff61\",\"c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914\",\"b786103d-c621-4f5a-b498-23452610f88c\"]" },
                    { new Guid("686ca643-87e1-46e4-82b2-96ae981f95b7"), "Home Kitchen", "[\"c4bbc4a2-4555-45d8-97cc-2a99b2167bff\"]" },
                    { new Guid("ac93c287-e185-472f-8dc0-c99b04b996de"), "Camera", "[\"93170c85-7795-489c-8e8f-7dcf3b4f4188\"]" },
                    { new Guid("e6f42685-5c79-418d-a598-f4330a3da14f"), "Electronics", "[]" },
                    { new Guid("eb6bf803-9549-496f-b2e3-629c496a23b6"), "Clothing", "[]" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"),
                column: "CategoryIds",
                value: "[\"04bb54af-5207-43ec-8541-4d4aecc1b280\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
                column: "CategoryIds",
                value: "[\"42dad73a-4745-4c24-b423-d0d880d804f7\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"),
                column: "CategoryIds",
                value: "[\"04bb54af-5207-43ec-8541-4d4aecc1b280\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"),
                column: "CategoryIds",
                value: "[\"ac93c287-e185-472f-8dc0-c99b04b996de\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b786103d-c621-4f5a-b498-23452610f88c"),
                column: "CategoryIds",
                value: "[\"42dad73a-4745-4c24-b423-d0d880d804f7\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"),
                column: "CategoryIds",
                value: "[\"686ca643-87e1-46e4-82b2-96ae981f95b7\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"),
                column: "CategoryIds",
                value: "[\"42dad73a-4745-4c24-b423-d0d880d804f7\"]");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryIds", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("2030fbe9-ab66-4830-885d-4e11a816739f"), "[\"e6f42685-5c79-418d-a598-f4330a3da14f\"]", "Latest model smartphone with great features.", "product-5.png", "HTC U11+ Plus", 380.00m },
                    { new Guid("20eeca62-0d1e-4629-ac70-366cc013dffb"), "[\"e6f42685-5c79-418d-a598-f4330a3da14f\"]", "Latest model smartphone with great features.", "product-6.png", "Panasonic Lumix", 240.00m },
                    { new Guid("5578ecd9-6c6c-4426-991c-a7c6ab67a11a"), "[\"e6f42685-5c79-418d-a598-f4330a3da14f\"]", "Latest model smartphone with great features.", "product-3.png", "Huawei Plus", 650.00m },
                    { new Guid("60a52a21-50b3-474c-ae07-bd7dc8a1c7d2"), "[\"1f325c6d-56a6-4e04-82f6-269e05fb598f\"]", "Fresh red apples.", "apple.jpg", "Apple", 0.99m },
                    { new Guid("71a085c0-8cba-4659-9502-36015d156a45"), "[\"e6f42685-5c79-418d-a598-f4330a3da14f\"]", "Latest model smartphone with great features.", "product-2.png", "Samsung 10", 840.00m },
                    { new Guid("8eaf13b5-8572-429e-9f97-de35fd571460"), "[\"e6f42685-5c79-418d-a598-f4330a3da14f\"]", "High performance laptop for gaming and work.", "laptop.jpg", "Laptop", 1299.99m },
                    { new Guid("aecc6156-b310-4395-9d9a-6749b698bb00"), "[\"e6f42685-5c79-418d-a598-f4330a3da14f\"]", "Latest model smartphone with great features.", "product-1.png", "IPhone X", 950.00m },
                    { new Guid("bdf3d2c1-5971-4252-8d74-0449971bb156"), "[\"eb6bf803-9549-496f-b2e3-629c496a23b6\"]", "Denim jeans that fit perfectly.", "jeans.jpg", "Jeans", 49.99m },
                    { new Guid("c66b143d-01cf-41e9-bb12-4def24cce8ff"), "[\"e6f42685-5c79-418d-a598-f4330a3da14f\"]", "Latest model smartphone with great features.", "product-4.png", "Xiaomi Mi 9", 470.00m },
                    { new Guid("cf1012d6-7b07-4e11-9d66-204b3bc50176"), "[\"eb6bf803-9549-496f-b2e3-629c496a23b6\"]", "Cotton t-shirt available in multiple colors.", "tshirt.jpg", "T-Shirt", 19.99m },
                    { new Guid("d15e3044-20cd-4685-b5f1-53aa77ae07b7"), "[\"e6f42685-5c79-418d-a598-f4330a3da14f\"]", "Latest model smartphone with great features.", "product-6.png", "LG G7 ThinQ", 240.00m },
                    { new Guid("f3a81022-b44d-415f-ab8f-4519a0072164"), "[\"1f325c6d-56a6-4e04-82f6-269e05fb598f\"]", "Whole grain bread.", "bread.jpg", "Bread", 2.49m }
                });

            migrationBuilder.InsertData(
                table: "CategoryProducts",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("1f325c6d-56a6-4e04-82f6-269e05fb598f"), new Guid("60a52a21-50b3-474c-ae07-bd7dc8a1c7d2") },
                    { new Guid("1f325c6d-56a6-4e04-82f6-269e05fb598f"), new Guid("f3a81022-b44d-415f-ab8f-4519a0072164") },
                    { new Guid("e6f42685-5c79-418d-a598-f4330a3da14f"), new Guid("8eaf13b5-8572-429e-9f97-de35fd571460") },
                    { new Guid("e6f42685-5c79-418d-a598-f4330a3da14f"), new Guid("aecc6156-b310-4395-9d9a-6749b698bb00") },
                    { new Guid("eb6bf803-9549-496f-b2e3-629c496a23b6"), new Guid("bdf3d2c1-5971-4252-8d74-0449971bb156") },
                    { new Guid("eb6bf803-9549-496f-b2e3-629c496a23b6"), new Guid("cf1012d6-7b07-4e11-9d66-204b3bc50176") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04bb54af-5207-43ec-8541-4d4aecc1b280"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42dad73a-4745-4c24-b423-d0d880d804f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("686ca643-87e1-46e4-82b2-96ae981f95b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac93c287-e185-472f-8dc0-c99b04b996de"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("1f325c6d-56a6-4e04-82f6-269e05fb598f"), new Guid("60a52a21-50b3-474c-ae07-bd7dc8a1c7d2") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("1f325c6d-56a6-4e04-82f6-269e05fb598f"), new Guid("f3a81022-b44d-415f-ab8f-4519a0072164") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e6f42685-5c79-418d-a598-f4330a3da14f"), new Guid("8eaf13b5-8572-429e-9f97-de35fd571460") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e6f42685-5c79-418d-a598-f4330a3da14f"), new Guid("aecc6156-b310-4395-9d9a-6749b698bb00") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("eb6bf803-9549-496f-b2e3-629c496a23b6"), new Guid("bdf3d2c1-5971-4252-8d74-0449971bb156") });

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("eb6bf803-9549-496f-b2e3-629c496a23b6"), new Guid("cf1012d6-7b07-4e11-9d66-204b3bc50176") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2030fbe9-ab66-4830-885d-4e11a816739f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20eeca62-0d1e-4629-ac70-366cc013dffb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5578ecd9-6c6c-4426-991c-a7c6ab67a11a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71a085c0-8cba-4659-9502-36015d156a45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c66b143d-01cf-41e9-bb12-4def24cce8ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d15e3044-20cd-4685-b5f1-53aa77ae07b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f325c6d-56a6-4e04-82f6-269e05fb598f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6f42685-5c79-418d-a598-f4330a3da14f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb6bf803-9549-496f-b2e3-629c496a23b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60a52a21-50b3-474c-ae07-bd7dc8a1c7d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8eaf13b5-8572-429e-9f97-de35fd571460"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aecc6156-b310-4395-9d9a-6749b698bb00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdf3d2c1-5971-4252-8d74-0449971bb156"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf1012d6-7b07-4e11-9d66-204b3bc50176"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3a81022-b44d-415f-ab8f-4519a0072164"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ProductIds" },
                values: new object[,]
                {
                    { new Guid("08bee5bb-d58e-4e6d-be7f-617eb463d3a6"), "White Appliances", "[\"4f136e9f-ff8c-4c1f-9a33-d12f689bdab8\",\"6ec1297b-ec0a-4aa1-be25-6726e3b51a27\"]" },
                    { new Guid("48cc1eb7-33f5-4a68-91a9-b982f14fa8c7"), "Home Kitchen", "[\"c4bbc4a2-4555-45d8-97cc-2a99b2167bff\"]" },
                    { new Guid("4abfe40d-6e05-4265-9ebe-0ed328bb4b75"), "Clothing", "[]" },
                    { new Guid("618fd955-b75c-41b8-a7c2-82d25865498b"), "Smart Phone", "[\"5334c996-8457-4cf0-815c-ed2b77c4ff61\",\"c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914\",\"b786103d-c621-4f5a-b498-23452610f88c\"]" },
                    { new Guid("86e8b44b-337a-48ae-8b84-7ee4bdfa3e29"), "Camera", "[\"93170c85-7795-489c-8e8f-7dcf3b4f4188\"]" },
                    { new Guid("8d1027b6-e0e5-4c7f-8d8a-054fd72122f0"), "Groceries", "[]" },
                    { new Guid("f81d9997-fcd4-4834-9937-7350f3d0316d"), "Electronics", "[]" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"),
                column: "CategoryIds",
                value: "[\"08bee5bb-d58e-4e6d-be7f-617eb463d3a6\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
                column: "CategoryIds",
                value: "[\"618fd955-b75c-41b8-a7c2-82d25865498b\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"),
                column: "CategoryIds",
                value: "[\"08bee5bb-d58e-4e6d-be7f-617eb463d3a6\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"),
                column: "CategoryIds",
                value: "[\"86e8b44b-337a-48ae-8b84-7ee4bdfa3e29\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b786103d-c621-4f5a-b498-23452610f88c"),
                column: "CategoryIds",
                value: "[\"618fd955-b75c-41b8-a7c2-82d25865498b\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"),
                column: "CategoryIds",
                value: "[\"48cc1eb7-33f5-4a68-91a9-b982f14fa8c7\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"),
                column: "CategoryIds",
                value: "[\"618fd955-b75c-41b8-a7c2-82d25865498b\"]");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryIds", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0a03166d-27e9-4b13-ba89-e6ad1fc3b32a"), "[\"8d1027b6-e0e5-4c7f-8d8a-054fd72122f0\"]", "Fresh red apples.", "apple.jpg", "Apple", 0.99m },
                    { new Guid("1dfc07f8-cf7a-4942-b1ae-7e4ecaeeeb89"), "[\"4abfe40d-6e05-4265-9ebe-0ed328bb4b75\"]", "Denim jeans that fit perfectly.", "jeans.jpg", "Jeans", 49.99m },
                    { new Guid("b9d02f70-50cf-4246-a3e8-c2bb3f8f4835"), "[\"8d1027b6-e0e5-4c7f-8d8a-054fd72122f0\"]", "Whole grain bread.", "bread.jpg", "Bread", 2.49m },
                    { new Guid("b9d539c4-7977-45eb-b5b4-5f0d554290b7"), "[\"f81d9997-fcd4-4834-9937-7350f3d0316d\"]", "High performance laptop for gaming and work.", "laptop.jpg", "Laptop", 1299.99m },
                    { new Guid("bc6c4ba1-62e0-44be-8cca-e4ee81318f69"), "[\"f81d9997-fcd4-4834-9937-7350f3d0316d\"]", "Latest model smartphone with great features.", "smartphone.jpg", "Smartphone", 699.99m },
                    { new Guid("e269c007-202f-4a0f-94a0-efdb3e7878f6"), "[\"4abfe40d-6e05-4265-9ebe-0ed328bb4b75\"]", "Cotton t-shirt available in multiple colors.", "tshirt.jpg", "T-Shirt", 19.99m }
                });

            migrationBuilder.InsertData(
                table: "CategoryProducts",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("4abfe40d-6e05-4265-9ebe-0ed328bb4b75"), new Guid("1dfc07f8-cf7a-4942-b1ae-7e4ecaeeeb89") },
                    { new Guid("4abfe40d-6e05-4265-9ebe-0ed328bb4b75"), new Guid("e269c007-202f-4a0f-94a0-efdb3e7878f6") },
                    { new Guid("8d1027b6-e0e5-4c7f-8d8a-054fd72122f0"), new Guid("0a03166d-27e9-4b13-ba89-e6ad1fc3b32a") },
                    { new Guid("8d1027b6-e0e5-4c7f-8d8a-054fd72122f0"), new Guid("b9d02f70-50cf-4246-a3e8-c2bb3f8f4835") },
                    { new Guid("f81d9997-fcd4-4834-9937-7350f3d0316d"), new Guid("b9d539c4-7977-45eb-b5b4-5f0d554290b7") },
                    { new Guid("f81d9997-fcd4-4834-9937-7350f3d0316d"), new Guid("bc6c4ba1-62e0-44be-8cca-e4ee81318f69") }
                });
        }
    }
}

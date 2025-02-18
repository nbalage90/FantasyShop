using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56efbf6a-5501-4372-a646-55d7f9e257a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80d73b9b-4597-4eab-8fe1-831ce1516b44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb038599-cb6b-4d3c-96ed-442d655671a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c893511c-5c55-4f84-8ff4-5b2abf8912cb"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("56efbf6a-5501-4372-a646-55d7f9e257a9"), "Smart Phone", "[\"5334c996-8457-4cf0-815c-ed2b77c4ff61\",\"c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914\",\"b786103d-c621-4f5a-b498-23452610f88c\"]" },
                    { new Guid("80d73b9b-4597-4eab-8fe1-831ce1516b44"), "Home Kitchen", "[\"c4bbc4a2-4555-45d8-97cc-2a99b2167bff\"]" },
                    { new Guid("bb038599-cb6b-4d3c-96ed-442d655671a7"), "White Appliances", "[\"4f136e9f-ff8c-4c1f-9a33-d12f689bdab8\",\"6ec1297b-ec0a-4aa1-be25-6726e3b51a27\"]" },
                    { new Guid("c893511c-5c55-4f84-8ff4-5b2abf8912cb"), "Camera", "[\"93170c85-7795-489c-8e8f-7dcf3b4f4188\"]" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"),
                column: "CategoryIds",
                value: "[\"bb038599-cb6b-4d3c-96ed-442d655671a7\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
                column: "CategoryIds",
                value: "[\"56efbf6a-5501-4372-a646-55d7f9e257a9\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"),
                column: "CategoryIds",
                value: "[\"bb038599-cb6b-4d3c-96ed-442d655671a7\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"),
                column: "CategoryIds",
                value: "[\"c893511c-5c55-4f84-8ff4-5b2abf8912cb\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b786103d-c621-4f5a-b498-23452610f88c"),
                column: "CategoryIds",
                value: "[\"56efbf6a-5501-4372-a646-55d7f9e257a9\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"),
                column: "CategoryIds",
                value: "[\"80d73b9b-4597-4eab-8fe1-831ce1516b44\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"),
                column: "CategoryIds",
                value: "[\"56efbf6a-5501-4372-a646-55d7f9e257a9\"]");
        }
    }
}

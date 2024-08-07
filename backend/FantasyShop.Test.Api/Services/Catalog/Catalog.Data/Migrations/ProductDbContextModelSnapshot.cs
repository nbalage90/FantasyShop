﻿// <auto-generated />
using System;
using Catalog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog.Data.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Catalog.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
                            Category = "[\"Smart Phone\"]",
                            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                            Image = "product-1.png",
                            Name = "IPhone X",
                            Price = 950.00m
                        },
                        new
                        {
                            Id = new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"),
                            Category = "[\"Smart Phone\"]",
                            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                            Image = "product-2.png",
                            Name = "Samsung 10",
                            Price = 840.00m
                        },
                        new
                        {
                            Id = new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"),
                            Category = "[\"White Appliances\"]",
                            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                            Image = "product-3.png",
                            Name = "Huawei Plus",
                            Price = 650.00m
                        },
                        new
                        {
                            Id = new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"),
                            Category = "[\"White Appliances\"]",
                            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                            Image = "product-4.png",
                            Name = "Xiaomi Mi 9",
                            Price = 470.00m
                        },
                        new
                        {
                            Id = new Guid("b786103d-c621-4f5a-b498-23452610f88c"),
                            Category = "[\"Smart Phone\"]",
                            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                            Image = "product-5.png",
                            Name = "HTC U11+ Plus",
                            Price = 380.00m
                        },
                        new
                        {
                            Id = new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"),
                            Category = "[\"Home Kitchen\"]",
                            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                            Image = "product-6.png",
                            Name = "LG G7 ThinQ",
                            Price = 240.00m
                        },
                        new
                        {
                            Id = new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"),
                            Category = "[\"Camera\"]",
                            Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                            Image = "product-6.png",
                            Name = "Panasonic Lumix",
                            Price = 240.00m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

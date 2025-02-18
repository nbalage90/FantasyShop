using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // Create categories
        var electronicsCategoryId = Guid.NewGuid();
        var clothingCategoryId = Guid.NewGuid();
        var groceriesCategoryId = Guid.NewGuid();

        var categories = new List<Category>
        {
            new Category
            {
                Id = electronicsCategoryId,
                Name = "Electronics",
                ProductIds = new List<Guid>()
            },
            new Category
            {
                Id = clothingCategoryId,
                Name = "Clothing",
                ProductIds = new List<Guid>()
            },
            new Category
            {
                Id = groceriesCategoryId,
                Name = "Groceries",
                ProductIds = new List<Guid>()
            },
        };

        // Create products
        var smartphoneId1 = Guid.NewGuid();
        var smartphoneId2 = Guid.NewGuid();
        var smartphoneId3 = Guid.NewGuid();
        var smartphoneId4 = Guid.NewGuid();
        var smartphoneId5 = Guid.NewGuid();
        var smartphoneId6 = Guid.NewGuid();
        var smartphoneId7 = Guid.NewGuid();
        var laptopId = Guid.NewGuid();
        var tshirtId = Guid.NewGuid();
        var jeansId = Guid.NewGuid();
        var appleId = Guid.NewGuid();
        var breadId = Guid.NewGuid();

        var products = new List<Product>
        {
            new Product
            {
                Id = smartphoneId1,
                Name = "IPhone X",
                Description = "Latest model smartphone with great features.",
                Image = "product-1.png",
                Price = 950.00M,
                CategoryIds = new List<Guid> { electronicsCategoryId }
            },
            new Product
            {
                Id = smartphoneId2,
                Name = "Samsung 10",
                Description = "Latest model smartphone with great features.",
                Image = "product-2.png",
                Price = 840.00M,
                CategoryIds = new List<Guid> { electronicsCategoryId }
            },
            new Product
            {
                Id = smartphoneId3,
                Name = "Huawei Plus",
                Description = "Latest model smartphone with great features.",
                Image = "product-3.png",
                Price = 650.00M,
                CategoryIds = new List<Guid> { electronicsCategoryId }
            },
            new Product
            {
                Id = smartphoneId4,
                Name = "Xiaomi Mi 9",
                Description = "Latest model smartphone with great features.",
                Image = "product-4.png",
                Price = 470.00M,
                CategoryIds = new List<Guid> { electronicsCategoryId }
            },
            new Product
            {
                Id = smartphoneId5,
                Name = "HTC U11+ Plus",
                Description = "Latest model smartphone with great features.",
                Image = "product-5.png",
                Price = 380.00M,
                CategoryIds = new List<Guid> { electronicsCategoryId }
            },
            new Product
            {
                Id = smartphoneId6,
                Name = "LG G7 ThinQ",
                Description = "Latest model smartphone with great features.",
                Image = "product-6.png",
                Price = 240.00M,
                CategoryIds = new List<Guid> { electronicsCategoryId }
            },
            new Product
            {
                Id = smartphoneId7,
                Name = "Panasonic Lumix",
                Description = "Latest model smartphone with great features.",
                Image = "product-6.png",
                Price = 240.00M,
                CategoryIds = new List<Guid> { electronicsCategoryId }
            },
            new Product
            {
                Id = laptopId,
                Name = "Laptop",
                Description = "High performance laptop for gaming and work.",
                Image = "laptop.jpg",
                Price = 1299.99M,
                CategoryIds = new List<Guid> { electronicsCategoryId }
            },
            new Product
            {
                Id = tshirtId,
                Name = "T-Shirt",
                Description = "Cotton t-shirt available in multiple colors.",
                Image = "tshirt.jpg",
                Price = 19.99M,
                CategoryIds = new List<Guid> { clothingCategoryId }
            },
            new Product
            {
                Id = jeansId,
                Name = "Jeans",
                Description = "Denim jeans that fit perfectly.",
                Image = "jeans.jpg",
                Price = 49.99M,
                CategoryIds = new List<Guid> { clothingCategoryId }
            },
            new Product
            {
                Id = appleId,
                Name = "Apple",
                Description = "Fresh red apples.",
                Image = "apple.jpg",
                Price = 0.99M,
                CategoryIds = new List<Guid> { groceriesCategoryId }
            },
            new Product
            {
                Id = breadId,
                Name = "Bread",
                Description = "Whole grain bread.",
                Image = "bread.jpg",
                Price = 2.49M,
                CategoryIds = new List<Guid> { groceriesCategoryId }
            }
        };

        // Create CategoryProduct relationships
        var categoryProducts = new List<CategoryProduct>
        {
            new CategoryProduct { ProductId = smartphoneId1, CategoryId = electronicsCategoryId },
            new CategoryProduct { ProductId = laptopId, CategoryId = electronicsCategoryId },
            new CategoryProduct { ProductId = tshirtId, CategoryId = clothingCategoryId },
            new CategoryProduct { ProductId = jeansId, CategoryId = clothingCategoryId },
            new CategoryProduct { ProductId = appleId, CategoryId = groceriesCategoryId },
            new CategoryProduct { ProductId = breadId, CategoryId = groceriesCategoryId },
        };

        // Add the seed data to the model builder
        modelBuilder.Entity<Category>().HasData(categories);
        modelBuilder.Entity<Product>().HasData(products);
        modelBuilder.Entity<CategoryProduct>().HasData(categoryProducts);
    }
}
using Catalog.Domain;
using System.Runtime.CompilerServices;

namespace Catalog.Data.Seed;
internal static class SeedingData
{
    private static readonly List<Product> seedingProducts;
    private static readonly List<Category> seedingCategories;
    private static readonly List<CategoryProduct> seedingCategoryProducts;

    public static List<Product> SeedingProducts
    {
        get { return seedingProducts; }
    }

    public static List<Category> SeedingCategories
    {
        get { return seedingCategories; }
    }

    public static List<CategoryProduct> SeedingCategoryProducts
    {
        get
        {
            return seedingCategoryProducts;
        }
    }

    static SeedingData()
    {
        seedingCategories = [
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Smart Phone"
            },
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "White Appliances"
            },
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Home Kitchen"
            },

            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Camera"
            },
        ];

        seedingProducts =
        [
            new Product()
            {
                Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
                Name = "IPhone X",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                Image = "product-1.png",
                Price = 950.00M,
                CategoryIds =
                [
                    seedingCategories.Single(c => c.Name == "Smart Phone").Id
                ]
            },
            new Product()
            {
                Id = new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914"),
                Name = "Samsung 10",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                Image = "product-2.png",
                Price = 840.00M,
                CategoryIds =
                [
                    seedingCategories.Single(c => c.Name == "Smart Phone").Id
                ]
            },
            new Product()
            {
                Id = new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8"),
                Name = "Huawei Plus",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                Image = "product-3.png",
                Price = 650.00M,
                CategoryIds =
                [
                    seedingCategories.Single(c => c.Name == "White Appliances").Id
                ]
            },
            new Product()
            {
                Id = new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27"),
                Name = "Xiaomi Mi 9",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                Image = "product-4.png",
                Price = 470.00M,
                CategoryIds =
                [
                    seedingCategories.Single(c => c.Name == "White Appliances").Id
                ]
            },
            new Product()
            {
                Id = new Guid("b786103d-c621-4f5a-b498-23452610f88c"),
                Name = "HTC U11+ Plus",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                Image = "product-5.png",
                Price = 380.00M,
                CategoryIds =
                [
                    seedingCategories.Single(c => c.Name == "Smart Phone").Id
                ]
            },
            new Product()
            {
                Id = new Guid("c4bbc4a2-4555-45d8-97cc-2a99b2167bff"),
                Name = "LG G7 ThinQ",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                Image = "product-6.png",
                Price = 240.00M,
                CategoryIds =
                [
                    seedingCategories.Single(c => c.Name == "Home Kitchen").Id
                ]
            },
            new Product()
            {
                Id = new Guid("93170c85-7795-489c-8e8f-7dcf3b4f4188"),
                Name = "Panasonic Lumix",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                Image = "product-6.png",
                Price = 240.00M,
                CategoryIds =
                [
                    seedingCategories.Single(c => c.Name == "Camera").Id
                ]
            }
        ];

        for (int i = 0; i < seedingCategories.Count; i++)
        {
            var category = seedingCategories[i];
            category.ProductIds = seedingProducts.Where(p => p.CategoryIds.Contains(category.Id)).Select(p => p.Id).ToList();

            seedingCategoryProducts ??= [];

            foreach (var productId in category.ProductIds)
            {
                seedingCategoryProducts.Add(new CategoryProduct
                {
                    CategoryId = category.Id,
                    ProductId = productId
            });
            }
        }
    }
}

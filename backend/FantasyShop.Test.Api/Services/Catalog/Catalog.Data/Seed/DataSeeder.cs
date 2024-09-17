using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data.Seed;
public static class DataSeeder
{
    public static async Task InitializeDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<CatalogDbContext>();

        context.Database.MigrateAsync().GetAwaiter().GetResult();

        await SeedProductsAsync(context);
        await SeedCategoriesAsync(context);
        //await SeedCategoryProductsAsync(context);
    }

    private static async Task SeedProductsAsync(CatalogDbContext context)
    {
        if (!await context.Products.AnyAsync())
        {
            context.AddRange(SeedingData.SeedingProducts);
        }
    }

    private static async Task SeedCategoriesAsync(CatalogDbContext context)
    {
        if (!await context.Categories.AnyAsync())
        {
            context.AddRange(SeedingData.SeedingCategories);
        }
    }

    //private static async Task SeedCategoryProductsAsync(CatalogDbContext context)
    //{
    //    if (!await context.CategoryProducts.AnyAsync())
    //    {
    //        context.AddRange(SeedingData.SeedingCategoryProducts);
    //    }
    //}
}

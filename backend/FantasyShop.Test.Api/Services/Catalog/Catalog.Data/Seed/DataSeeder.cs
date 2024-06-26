using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data.Seed;
public static class DataSeeder
{
    public static async Task InitializeDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<ProductDbContext>();

        context.Database.MigrateAsync().GetAwaiter().GetResult();

        await SeedProductsAsync(context);
    }

    private static async Task SeedProductsAsync(ProductDbContext context)
    {
        if (!await context.Products.AnyAsync())
        {
            context.AddRange(SeedingData.SeedingProducts);
        }
    }
}

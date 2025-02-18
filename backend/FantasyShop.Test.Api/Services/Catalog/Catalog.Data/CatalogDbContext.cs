using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Catalog.Data;
public class CatalogDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryProduct> CategoryProducts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Seed(); // Call the seed method to seed data

        base.OnModelCreating(modelBuilder);
    }
}

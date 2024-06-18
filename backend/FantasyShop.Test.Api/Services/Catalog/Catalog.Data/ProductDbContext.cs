using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Catalog.Data;
public class ProductDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Data.Configuration;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasMany(p => p.Categories)
            .WithMany(c => c.Products)
            .UsingEntity<CategoryProduct>(
                l => l.HasOne<Category>().WithMany().HasForeignKey(e => e.CategoryId),
                r => r.HasOne<Product>().WithMany().HasForeignKey(e => e.ProductId));
    }
}

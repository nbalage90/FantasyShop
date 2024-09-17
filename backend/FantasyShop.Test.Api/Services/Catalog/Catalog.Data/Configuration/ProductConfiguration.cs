using Catalog.Data.Seed;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Data.Configuration;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // TODO: load navigation properties

        builder.HasData(SeedingData.SeedingProducts);

        //builder.HasMany(p => p.Categories)
        //    .WithMany(c => c.Products);
    }
}

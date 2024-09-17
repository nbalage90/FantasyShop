﻿using Catalog.Data.Seed;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Data.Configuration;
internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        // TODO: load navigation properties

        builder.HasData(SeedingData.SeedingCategories);

        builder.HasMany(c => c.Products)
            .WithMany(p => p.Categories)
            .UsingEntity(p => p.ToTable("CategoryProduct"));
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(p => p.MyProviders)
                .WithMany(prod=>prod.MyProds)
                .UsingEntity(e =>e.ToTable("Providing"));

            builder.HasOne(p => p.MyCat)
                .WithMany(prod => prod.MyProducts)
                .HasForeignKey(Pr => Pr.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Many to Many
            builder.HasMany(p => p.Providers)
            .WithMany(v => v.Products)
            .UsingEntity(
                j => j.ToTable("Providings"));//Table d'association

            //One To Many
            builder.HasOne(p => p.MyCategory)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);// the values of foreign key properties in dependent entities are set to null when the related principal is deleted

            //Many to Many 
            builder.HasMany(p => p.Clients)
            .WithMany(c => c.Products)
            .UsingEntity<Facture>(
                j => j
                    .HasOne(f => f.Client)
                    .WithMany(c => c.Factures)
                    .HasForeignKey(c => c.ClientFk),
                j => j
                    .HasOne(f => f.Product)
                    .WithMany(p => p.Factures)
                    .HasForeignKey(p => p.ProductFk),
                j =>
                {
                    j.Property(f => f.DateAchat).HasDefaultValueSql("CURRENT_TIMESTAMP");
                    j.HasKey(f => new { f.DateAchat, f.ClientFk, f.ProductFk });
                });


            //builder.Property(p => p.Name).HasColumnName("MyName");
        }
    }
}

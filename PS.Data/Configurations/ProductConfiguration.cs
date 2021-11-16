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
            //ManyToMany
            builder.HasMany(prod => prod.Providers)
                .WithMany(prov => prov.Products)  //relation many-many
                .UsingEntity(e => e.ToTable("Providing")); //table d'association
            //OneToMany
            builder.HasOne(prod => prod.MyCategory)
                .WithMany(cat => cat.Products) //relation one-many
                .HasForeignKey(prod => prod.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull); //yab9ou l données just l clé étrangère ywali null 
            //
            /*builder.HasDiscriminator<int>("IsBiological")
                .HasValue<Biological>(1)
                .HasValue<Chemical>(2)
                .HasValue<Product>(0);*/

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
                    .HasForeignKey(p => p.ProductFK),
                j =>
                {
                    j.Property(f => f.DateAchat).HasDefaultValueSql("CURRENT_TIMESTAMP");
                    j.HasKey(f => new { f.DateAchat, f.ClientFk, f.ProductFK });
                });

        }

    }
}

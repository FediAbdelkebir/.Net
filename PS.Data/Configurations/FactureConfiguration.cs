using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PS.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PS.Data.Configurations
{
    public class FactureConfiguration : IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            builder.HasKey(f => new {
                f.ClientFk,
                f.ProductFK,
                f.DateAchat
            });
            builder.HasOne(f => f.Client)
                .WithMany(c => c.Factures)
                .HasForeignKey(f => f.ClientFk);
            builder.HasOne(f => f.Product)
                .WithMany(c => c.Factures)
                .HasForeignKey(f => f.ProductFK);
        }
    }
}

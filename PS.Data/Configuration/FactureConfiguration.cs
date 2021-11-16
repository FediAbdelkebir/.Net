using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;
namespace PS.Data.Configuration
{
    class FactureConfiguration:IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> Builder)
        {
            Builder.HasKey(f => new { f.ClientFK, f.ProductFk, f.DateAchat });
            Builder.HasOne(f => f.Client)
                .WithMany(c => c.Factures)
                .HasForeignKey(f => f.ClientFK);
            Builder.HasOne(f => f.Product)
                .WithMany(c => c.Factures)
                .HasForeignKey(f => f.ProductFk);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    public class ChamicalConfiguration : IEntityTypeConfiguration<Chemical>
    {
        public void Configure(EntityTypeBuilder<Chemical> builder)
        {
            builder.OwnsOne(c => c.MyAddress, //[owned] config type d'entité détenu 
                adr => { 
                    adr.Property(x => x.City).IsRequired().HasColumnName("MyCity");
                    adr.Property(x => x.StreetAddress).IsRequired().HasMaxLength(50).HasColumnName("MyAdress");
                }
            );
        }
    }
}

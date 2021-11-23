using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    public class ChemicalConfiguration : IEntityTypeConfiguration<Chemical>
    {

        public void Configure(EntityTypeBuilder<Chemical> builder)
        {
            builder.OwnsOne(c => c.MyAddress, myadd =>
            {
                myadd.Property(a => a.StreetAddress).HasColumnName("MyStreet").HasMaxLength(50);
                myadd.Property(a => a.City).HasColumnName("MyCity").IsRequired();
            });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
   public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(p => p.City).IsRequired().HasColumnName("MyCity");
            builder.Property(p => p.StreetAddress).HasMaxLength(50).HasColumnName("MyStreet");

        }
    }
}
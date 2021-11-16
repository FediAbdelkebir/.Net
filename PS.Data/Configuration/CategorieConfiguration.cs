using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configuration
{
    public class CategorieConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable ("MyCategorie" );
            builder.HasKey(c=>c.CategoryId);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50).HasColumnName("MyName");
        }
    }
}

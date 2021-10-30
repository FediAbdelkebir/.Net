using Microsoft.EntityFrameworkCore;
using PS.Data.Configuration;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data
{
    public class PSContext:DbContext 
    {
        public PSContext()
        {
            //Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=FediAbdelkebirDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            new CategorieConfiguration().Configure(modelbuilder.Entity<Category>());

            new ProductConfiguration().Configure(modelbuilder.Entity<Product>());

            new ChemicalConfiguration().Configure(modelbuilder.Entity<Chemical>());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Biological> Biologicals { get; set; }


    }
}

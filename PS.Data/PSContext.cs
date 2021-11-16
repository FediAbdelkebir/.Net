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
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            modelbuilder.Entity<Category>().Property(p => p.Name).HasColumnName("MyName");
            modelbuilder.Entity<Product>().Property(p => p.Name).HasColumnName("MyName");

            new CategorieConfiguration().Configure(modelbuilder.Entity<Category>());

            new ProductConfiguration().Configure(modelbuilder.Entity<Product>());

            new ChemicalConfiguration().Configure(modelbuilder.Entity<Chemical>());
            new FactureConfiguration().Configure(modelbuilder.Entity<Facture>());
           
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Facture> Factures { get; set; }

    }
}

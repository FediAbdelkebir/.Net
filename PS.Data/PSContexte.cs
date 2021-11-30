using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PS.Data.Configurations;
using PS.Domain;

namespace PS.Data
{
    public class PSContexte:DbContext
    {
        public PSContexte(DbContextOptions options):base(options)
        {

        }
        public PSContexte()
        {
            //Database.EnsureCreated();
            //n'est pas compatible avec la migartion de db 

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=FediAbdelkebir;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        //dbset : table dans bd

        public DbSet<Product> Products { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("MyName");
            //modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnName("MyName");
            new CategoryConfiguration().Configure(modelBuilder.Entity<Category>());
            new ProductConfiguration().Configure(modelBuilder.Entity<Product>());
            new ChamicalConfiguration().Configure(modelBuilder.Entity<Chemical>());
            new FactureConfiguration().Configure(modelBuilder.Entity<Facture>());

            //config tous les prop de typoe string et dont nom commence par name
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string) && p.Name.StartsWith("Name"))
            )
            {
                property.SetColumnName("MyName");
            }

            /*modelBuilder.Entity<Product>()
                .HasDiscriminator<int>("IsBiological")
                .HasValue<Biological>(1)
                .HasValue<Chemical>(2)
                .HasValue<Product>(0);*/
            
            modelBuilder.Entity<Chemical>().ToTable("Chemicals");
            modelBuilder.Entity<Biological>().ToTable("Biologicals");
        }

    }
}

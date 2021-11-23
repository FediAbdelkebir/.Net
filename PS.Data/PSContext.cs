using Microsoft.EntityFrameworkCore;
using PS.Data.Configurations;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Data
{
    public class PSContext : DbContext
    {
        //public PSContext(DbContextOptions options) : base(options)
        //{

        //}

        public PSContext()
        {
            //Database.Migrate();
            //Database.EnsureCreated();
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AtallahDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Faire appel aux classes de configuration que nous venons de créer(1ère méthode) 
            new CategoryConfiguration().Configure(modelBuilder.Entity<Category>());
            new ProductConfiguration().Configure(modelBuilder.Entity<Product>());
            new ChemicalConfiguration().Configure(modelBuilder.Entity<Chemical>());
            //new FactureConfiguration().Configure(modelBuilder.Entity<Facture>());




            //Faire appel aux classes de configuration que nous venons de créer(2eme méthode) 
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new ChemicalConfiguration());
            ////modelBuilder.ApplyConfiguration(new FactureConfiguration());

            //Configurer toute les propriétés de type string et dont le nom commence par “Name”
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                        .SelectMany(t => t.GetProperties())
                        .Where(p => p.ClrType == typeof(string) && p.Name.StartsWith("Name")))
            {
                property.SetColumnName("MyName");
            }

            ////TPH
            //modelBuilder.Entity<Product>()
            //            .HasDiscriminator<int>("IsBiological")
            //            .HasValue<Biological>(1)
            //            .HasValue<Chemical>(2)
            //            .HasValue<Product>(0);

            //TPT
            modelBuilder.Entity<Biological>().ToTable("Biologicals");
            modelBuilder.Entity<Chemical>().ToTable("Chemicals");

            //modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("MyName");

            ////Configurer le type d’entité détenu Address
            ////Methode1:
            //modelBuilder.Entity<Chemical>().OwnsOne(c => c.MyAddress, myadd =>
            //{
            //    myadd.Property(a => a.StreetAddress).HasColumnName("MyStreet").HasMaxLength(50); ;
            //    myadd.Property(a => a.City).HasColumnName("MyCity").IsRequired();
            //});

            ////Methode2:
            //modelBuilder.Entity<Chemical>().OwnsOne(typeof(Address), "MyAddress");

            ////Configurer le nom de toutes les tables
            //foreach (var entity in modelBuilder.Model.GetEntityTypes())
            //{
            //   if (entity.Name != "Address") { modelBuilder.Entity(entity.Name).ToTable("Table" + entity.Name); }
            //   }


            ////Configurer les propriétés nommées Key comme clé primaire
            //foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties())
            //            .Where(p => p.Name == "CIN"))
            //{
            //    property.IsPrimaryKey();

            //}


            //            foreach (var property in modelBuilder.Model.GetEntityTypes()
            //.SelectMany(t => t.GetProperties())
            //.Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            //            {
            //                if (property.GetColumnType() == null)
            //                    property.SetColumnType("decimal(13,4)");
            //            }
        }
    }
}
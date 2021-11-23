using Microsoft.EntityFrameworkCore;
using PS.Data;
using PS.Domain;
using System;
using System.Linq;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            Scenario1();

        }
        static void Scenario1()
        {
            using (var context = new PSContext())
            {
                //context.Database.EnsureCreated();
                //context.Database.Migrate();
                //Create
                System.Console.WriteLine("Create");
                //Instancier un objet Category
                Category C = new Category { Name = "Cat1" };
                //Instancier un objet Product
                Product P = new Product { Name = "Prod1", DateProd = DateTime.Now, MyCategory=C };
                //Ajouter l'objet au DBSET
                context.Products.Add(P);
                //Persister les données
                context.SaveChanges();

                //Read All
                System.Console.WriteLine("Read All");
                foreach (Product p in context.Products)
                {
                    System.Console.WriteLine(p.ProductId + " " + p.Name);
                }

                //Read Last
                System.Console.WriteLine("Read Last");
                var prod = context.Products.OrderBy(p => p.ProductId)
                    .Last();
                System.Console.WriteLine(prod.ProductId + " " + prod.Name + " " + prod.MyCategory.Name);

                // Update
                System.Console.WriteLine("Update");
                prod.Name = "newName";
                context.SaveChanges();
                System.Console.WriteLine(prod.ProductId + " " + prod.Name);

                // Delete
                //System.Console.WriteLine("Delete the product");
                //context.Remove(prod);
                //context.SaveChanges();

            }
        }
    }
}
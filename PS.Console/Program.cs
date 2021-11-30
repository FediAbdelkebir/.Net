using PS.Domain;
using PS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using PS.Service;
using PS.Data.Infrastructures;

namespace PS.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            /************** TP1 **************/
            //System.Console.WriteLine("Hello World!");
            //Provider p1 = new Provider {
            //    UserName = "provider1",
            //    Password = "12345",
            //    ConfirmPassword = "12345",
            //    Email = "provider1@gmail.com",
            //    IsApproved = false,
            //    } ;

            //p1.GetDetails();
            //System.Console.WriteLine("\nméthode a");
            //Provider.SetIsApproved(p1);
            //p1.GetDetails();
            //bool isapproved = p1.IsApproved;
            //System.Console.WriteLine("\nméthode b");
            //Provider.SetIsApproved(p1.Password, p1.ConfirmPassword, ref isapproved); 
            //p1.IsApproved = isapproved;
            //p1.GetDetails();

            ////Test T1 = new Domain.Test();
            ////var x = 1;
            ////var y = 2;
            ////T1.fonc(x, y);
            ////System.Console.WriteLine($"x={x},y={y}");
            ////T1.fonc2(ref x, ref y);
            ////System.Console.WriteLine($"x={x},y={y}");


            //// passage par valeur : kif nokhroj mel fonctions tarja3 l valeur kifma kenet

            //System.Console.WriteLine("\nlogin");
            //System.Console.WriteLine("Authentification : " + p1.Login(p1.UserName, p1.Password));
            //System.Console.WriteLine("Authentification : " + p1.Login(p1.UserName, p1.Password, p1.Email));

            //System.Console.WriteLine("\ntypes");
            //Product product = new Product();
            //System.Console.WriteLine(product.GetMyType());
            //Chemical chemical = new Chemical();
            //System.Console.WriteLine(chemical.GetMyType());
            //Biological biological = new Biological();
            //System.Console.WriteLine(biological.GetMyType());

            //System.Console.WriteLine("\ngetDetails");

            /*Category cat1 = new Category() { Name = "CAT1" };
            Category cat2 = new Category() { Name = "CAT2" };
            Category cat3 = new Category() { Name = "CAT3" };

            Provider prov1 = new Provider() { UserName = "PROV1" };
            Provider prov2 = new Provider() { UserName = "PROV2" };
            Provider prov3 = new Provider() { UserName = "PROV3" };
            Provider prov4 = new Provider() { UserName = "PROV4" };
            Provider prov5 = new Provider() { UserName = "PROV5" };

            Product prod1 = new Product() { Name = "PROD1", MyCategory = cat1, Providers = new List<Provider>() { prov1, prov2, prov3 } };
            Product prod2 = new Product() { Name = "PROD2", MyCategory = cat1, Providers = new List<Provider>() { prov1 } };
            Product prod3 = new Product() { Name = "PROD3", MyCategory = cat3, Providers = new List<Provider>() { prov1 } };
            Product prod4 = new Product() { Name = "PROD4", Providers = new List<Provider>() { prov3, prov4, prov5 } };
            Product prod5 = new Product() { Name = "PROD5", MyCategory = cat2, Providers = new List<Provider>() { } };
            Product prod6 = new Product() { Name = "PROD6", MyCategory = cat3, Providers = new List<Provider>() { prov4, prov5 } };

            cat1.Products = new List<Product>() { prod1, prod2 };
            cat2.Products = new List<Product>() { prod5 };
            cat3.Products = new List<Product>() { prod3, prod6 };
            prov1.Products = new List<Product>() { prod1, prod2, prod3 };
            prov2.Products = new List<Product>() { prod1, prod5 };
            prov3.Products = new List<Product>() { prod1 };
            prov4.Products = new List<Product>() { prod4, prod6 };
            prov5.Products = new List<Product>() { prod4, prod6 };*/


            //System.Console.WriteLine("détails des providers");
            //prov1.GetDetails();
            //prov2.GetDetails();
            //prov3.GetDetails();

            //System.Console.WriteLine("\nfiltre par date : ");
            //prov1.GetProducts("DateProd", "01/01/0001");
            //System.Console.WriteLine("filtre par nom : ");
            //prov1.GetProducts("Name", "PROD1");

            //System.Console.WriteLine("***************************** tp2 *****************************");

            //System.Console.WriteLine("***************************** tp3 *****************************");

            /*using (var context = new PSContexte())
            {
                //Create
                System.Console.WriteLine("Create");
                //Instancier un objet Product
                Product P = new Product
                {
                    Name = "Prod1",
                    DateProd = DateTime.Now
                };

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
                System.Console.WriteLine(prod.ProductId + " " + prod.Name);


                // Update
                System.Console.WriteLine("Update");
                prod.Name = "newName";
                context.SaveChanges();
                System.Console.WriteLine(prod.ProductId + " " + prod.Name);


                // Delete
                System.Console.WriteLine("Delete the product");
                context.Remove(prod);
                context.SaveCh
            anges();

            }*/


            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddScoped<ICategoryService, CategoryService>()
                .AddTransient<IUnitOfWork, UnitOfWork>()
                .AddSingleton<IDatabaseFactory, DatabaseFactory>()
                .BuildServiceProvider();
            //do the actual work here
            var serviceCategory = serviceProvider.GetService<ICategoryService>();
            serviceCategory.Add(new Category() { Name = "Cat1" });
            serviceCategory.Commit();

        }
    }
}

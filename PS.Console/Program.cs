using PS.Domain;
using System;
using System.Collections.Generic;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            Provider P1 = new Provider
            {
                UserName = "aaaa",
                Password = "123456",
                Email = "Fedi@Fedi.Fedi",
                ConfirmPassword = "12",
                IsApproved = false,
                products = new System.Collections.Generic.List<Product>() { }
            };

            Category cat1 = new Category() { Name = "CAT1" };
            Category cat2 = new Category() { Name = "CAT2" };
            Category cat3 = new Category() { Name = "CAT3" };

            Provider prov1 = new Provider() { UserName = "PROV1" };
            Provider prov2 = new Provider() { UserName = "PROV2" };
            Provider prov3 = new Provider() { UserName = "PROV3" };
            Provider prov4 = new Provider() { UserName = "PROV4" };
            Provider prov5 = new Provider() { UserName = "PROV5" };

            Product prod1 = new Product() { Name = "PROD1", Mycategory = cat1, Providers = new List<Provider>() { prov1, prov2, prov3 } };
            Product prod2 = new Product() { Name = "PROD2", Mycategory = cat1, Providers = new List<Provider>() { prov1 } };
            Product prod3 = new Product() { Name = "PROD3", Mycategory = cat3, Providers = new List<Provider>() { prov1 } };
            Product prod4 = new Product() { Name = "PROD4", Providers = new List<Provider>() { prov3, prov4, prov5 } };
            Product prod5 = new Product() { Name = "PROD5", Mycategory = cat2, Providers = new List<Provider>() { } };
            Product prod6 = new Product() { Name = "PROD6", Mycategory = cat3, Providers = new List<Provider>() { prov4, prov5 } };

            cat1.Products = new List<Product>() { prod1, prod2 };
            cat2.Products = new List<Product>() { prod5 };
            cat3.Products = new List<Product>() { prod3, prod6 };

            prov1.products = new List<Product>() { prod1, prod2, prod3 };
            prov2.products = new List<Product>() { prod1, prod5 };
            prov3.products = new List<Product>() { prod1 };
            prov4.products = new List<Product>() { prod4, prod6 };
            prov5.products = new List<Product>() { prod4, prod6 };


            System.Console.WriteLine("détails des providers");
            prov1.GetDetails();
            prov2.GetDetails();
            prov3.GetDetails();

            //P1.GetDetails();
            //Provider.SetIsApproved(P1);
            /* 
              System.Console.WriteLine("methode a");
              //
              bool isapproved = P1.IsApproved;
              Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, ref isapproved);
              System.Console.WriteLine("Méthode B");
              P1.IsApproved = isapproved;
              P1.GetDetails();
              P1.login(P1.Password, P1.Email);

          */
            /*
            Test T1 = new Test();
            int x =10;
            int y =20;
            T1.MethodParValeur(x,y);
            T1.MethodParReferance(ref x,ref y);
            */

            //P1.GetDetails();

        }
    }
}


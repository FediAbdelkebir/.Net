using PS.Data;
using PS.Domain;
using System;
using System.Collections.Generic;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new PSContext())
            {

                System.Console.WriteLine("Create");

                Product P = new Product
                {
                    Name = "Prod1",
                    DateProd = DateTime.Now
                };
                context.Products.Add(P);

                context.SaveChanges();
                Product P2 = new Product
                {
                    Name = "Prod2",
                    DateProd = DateTime.Now
                };
                context.Products.Add(P2);

                context.SaveChanges();
            }
            
        }
        
            //System.Console.WriteLine("Hello SAE4 !!");
            //Product p2 = new Product
            //{
            //    Name = "water"
            //};
            //Provider P1 = new Provider
            //{
            //    Username = "Ahmed",
            //    Email = "Ahmedbannour77@gmail.com",
            //    Password = "12345",
            //    ConfirmPassword = "12345",
            //    IsApproved = false,
            //    MyProds = new List<Product>() {p2}
            //};
            //*P1.GetDetails();
            //Provider.SetIsApproved(P1);
            //P1.GetDetails();*
            //P1.GetDetails();
            //System.Console.WriteLine(P1.Login("Ahmed", "123456"));
            //System.Console.WriteLine(P1.Login("Ahmed", "12345", "Ahmedbannour77@gmail.com"));
            //*bool isApprved = P1.IsApproved;
            //P1.SetIsApproved(P1.Password, P1.ConfirmPassword, ref isApprved);
            //P1.IsApproved = isApprved;
            //P1.GetDetails();*
            //Product Prod1 = new Product{};
            //System.Console.WriteLine(Prod1.GetMyType()); 
            //Chemical ch1 = new Chemical { };
            //System.Console.WriteLine(ch1.GetMyType());
            //Biological bio1 = new Biological { };
            //System.Console.WriteLine(bio1.GetMyType());



        }
}

using PS.Domain;
using System;

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


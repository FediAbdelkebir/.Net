using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
   public  class Provider:Concept 
    {
        private String confirmPasswd;
        public DateTime DateCreate { get; set; }
        public String Email { get; set; }
        public int id { get; set; }
        public Boolean IsApproved { get; set; }

        private String passwd;
        public string Password
        {
            get { return passwd; }
            set
            {
            if(value.Length>20 || value.Length < 5)
                {
                    System.Console.WriteLine("Mot de Pass InValide ;c");
                }
                else { passwd = value; }
            }
        }
        
        public string ConfirmPassword
        {
            get { return confirmPasswd; }
            set
            {
                if (!value.Equals(passwd))
                {
                    System.Console.WriteLine("Mot de Pass ne correspond pas ;c");
                }
                else { confirmPasswd = value; }
            }
        }
        public String UserName { get; set; }
        public IList<Product> products { get; set; }

        public override void GetDetails()
        {
         
            System.Console.WriteLine(" UserName: " + UserName + " Password :" + passwd + " ConfirmePassword"+confirmPasswd+" Is Approved ? : "+IsApproved  );

            if (products.Count != 0)
            {
                foreach (Product p in products)
                {
                    p.GetDetails();
                }
            }
            else { System.Console.WriteLine("La Liste Est Vide"); }
        }
        public static void SetIsApproved (Provider P)
        {
            P.IsApproved = P.passwd.CompareTo(P.confirmPasswd) == 0;
        }
        public static void SetIsApproved(string Password  , string confirmPassword , ref bool isApproved)
        {
            isApproved = Password.CompareTo(confirmPassword) == 0;
        }
        public bool login(string password,string email)
        {
            if (password.Equals(passwd) && email.Equals(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
        public bool login(string username,string password, string email)
        {
            if (username.Equals(username) && password.Equals(passwd) && email.Equals(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void GetProducts(String Type,String Value)
        {
            switch (Type)
            {
                case("Name"):
                    foreach (Product p in products)
                    {

                    }
                    break;
                case ("Description"):
                    foreach (Product p in products)
                    {

                    }
                    break;
                case ("Price"):
                    foreach (Product p in products)
                    {

                    }
                    break;
                case ("City"):
                    foreach (Product p in products)
                    {

                    }
                    break;
                case ("DateProd"):
                    foreach (Product p in products)
                    {

                    }break;
                case ("ProductId"):
                    foreach (Product p in products)
                    {

                    }
                    break;
                case ("Quantity"):
                    foreach (Product p in products)
                    {

                    }
                    break;
            }
        }
    }
}

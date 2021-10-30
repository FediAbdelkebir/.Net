using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Provider:Concept
    {
        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set {
                if (value.CompareTo(Password)==0) 
                {
                    confirmPassword = value;
                }
                else {
                    System.Console.WriteLine("Confirmation incorrecte !!");
                }
            }
        }

        public DateTime DateCreated { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        private string password;
        [DataType(DataType.Password),Required,Compare("Password"),NotMapped]
        public string Password
        {
            get { return password; }
            set { 
                if (value.Length > 20 || value.Length < 5){
                        System.Console.WriteLine("Verifiez votre mdp svp !!");
                        
                    }else{
                        password = value;
                    }
            }
        }

        public string Username { get; set; }
        public IList<Product> MyProds { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Username : " + Username + " , Password : " + Password + " , Confirm Password : " + ConfirmPassword + " , IsApproved : " + IsApproved + " , My Products : \n");
            if(MyProds == null)
            {
                Console.WriteLine("no product");
            }else{
                foreach (Product p in MyProds)
                {
                    p.GetDetails();
                }
            }
        }
        /*public static void SetIsApproved(Provider p)
        {
            p.IsApproved = p.ConfirmPassword.CompareTo(p.Password) ==0;
        }*/
        public void SetIsApproved(string password, string confirmPassword, ref bool isApproved)
        {
            isApproved = (password.CompareTo(confirmPassword) == 0);
        }
        /*public bool Login (string username , string password)
        {
            return (this.Username == username && this.Password == password);
        }
        public bool Login(string username, string password , string email)
        {
            return (this.Username == username && this.Password == password && this.Email==email);
        }*/
        public bool Login(string username, string password, string email=null)
        {
            if(email != null)
            {
                return (this.Username == username && this.Password == password && this.Email == email);
            }
            else
            {
                return (this.Username == username && this.Password == password );
            }
        }

       

    }
    
}

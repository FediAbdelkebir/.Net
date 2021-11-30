using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Provider:Concept
    {
        //propfull double tab
        //prop double tab

        private string confirmPassword;

        [Required,
            DataType(DataType.Password),
            Compare("Password"),
            NotMapped] //maandich colonne f bd esemha confirm password
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (value.Equals(password)) //confirmPasword == password
                {
                    confirmPassword = value;
                    //System.Console.WriteLine("Mot de passe confirmé !");
                }
                else
                {
                    System.Console.WriteLine("Vérifier le mot de passe");
                }
            }
        }

        public DateTime DateCreated { get; set; }

        [Required,
            DataType(DataType.EmailAddress)] //[EmailAddress]
        public string Email { get; set; }

        [Key] //càd cet variable est clé primaire 
        public int Id { get; set; }
        public bool IsApproved { get; set; }

        private string password;

        [DataType(DataType.Password),
            MaxLength(8),
            Required]
        public string Password
        {
            get { return password; }
            set { 
                if(value.Length > 20 || value.Length < 5)
                {
                    System.Console.WriteLine("Vérifier le password !");
                }
                else
                {
                    password = value;
                    System.Console.WriteLine("Mot de passe valide");
                }
            }
        }

        public string UserName { get; set; }
        public virtual IList<Product> Products { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("User Name: " + UserName +
                ", Password: " + Password + 
                ", Confirm Password: " + ConfirmPassword + 
                ", IsApproved: " + IsApproved);
            if(Products != null)
            {
                foreach (Product p in Products)
                {
                    p.GetDetails();
                }
            }
        }

        public static void SetIsApproved(string password, string confirmPassword, ref bool isApproved)     //passage par valeur
        {
            isApproved = password.CompareTo(confirmPassword) == 0;
        }
        public static void SetIsApproved(Provider P)    //passage par référence
        {
            P.IsApproved = P.Password.CompareTo(P.ConfirmPassword) == 0;
        }

        public bool Login(string username, string password)
        {
            return this.UserName == username && this.Password == password;
            //return this.UserName.Equals(username) && this.Password.Equals(password);
        }
        public bool Login(string username, string password, string email)
        {
            return this.UserName == username && this.Password == password && this.Email == email;
        }

        public void GetProducts(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "DateProd":
                    {
                        foreach (Product p in Products)
                        {
                            if (p.DateProd.ToString().Contains(filterValue))
                            //if (p.DateProd.CompareTo(filterValue) == 0)
                            {
                                p.GetDetails();
                            }
                        }
                    }
                break;
                case "Name":
                    {
                        foreach (Product p in Products)
                        {
                            if (p.Name.Equals(filterValue))
                            {
                                p.GetDetails();
                            }
                        }
                    }
                    break;


            }
        }

    }
}


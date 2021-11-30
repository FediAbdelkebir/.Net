using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Product:Concept
    {
        [DataType(DataType.DateTime),
            Display(Name="Production Date")]
        public DateTime DateProd { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage="Name is required."),
            StringLength(25, ErrorMessage = "Must be less than 25 caracters."),
            MaxLength(50)]//longeur dans bd 
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        //l'id doit être : Id ou Nom_ClasseId
        public int ProductId { get; set; }

        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
        public virtual Category MyCategory { get; set; }
        public string ImageName { get; set; }
        public virtual IList<Provider> Providers { get; set; }
        public virtual IList<Facture> Factures { get; set; }
        public virtual IList<Client> Clients { get; set; }

        [ForeignKey("CategoryId")] 
        public int? CatId { get; set; }
        // ? : aceeprter valeur null


        public override void GetDetails()
        {
            System.Console.WriteLine("Date Prod: " + DateProd + 
                "Description: " + Description + 
                ", Name: " + Name +
                ", Price: " + Price + 
                ", Product Id: " + ProductId + 
                ", Quantity: " + Quantity);
        }

        public virtual string GetMyType()
        {
            return "My type : UNKNOWN";
        }

        
    }
}

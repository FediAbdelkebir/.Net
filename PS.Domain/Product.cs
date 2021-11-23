using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Product:Concept
    {
        [DataType(DataType.ImageUrl), Display(Name = "Image")]
        public string Image2 { get; set; }
        [Display(Name = "Production Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public int ProductId { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        //foreign Key properties
        //[ForeignKey("MyCategory")]//meth1
        public virtual int? CategoryId { get; set; }
        //navigation properties
        [ForeignKey("CategoryId")] //meth2 useless in this case 
        public virtual Category MyCategory { get; set; }
        public virtual IList<Provider> Providers { get; set; }
        public virtual IList<Client> Clients { get; set; }
        public virtual IList<Facture> Factures { get; set; }


        public override void GetDetails()
        {
            System.Console.WriteLine("Name:" + Name + " Price:" + Price + " Quantity:" + Quantity);
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("UNKNOWN");

        }
    }
}
 
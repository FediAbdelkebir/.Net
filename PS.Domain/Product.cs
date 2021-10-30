 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Product : Concept
    {
        [Display(Name="Production Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage ="Name is required"),StringLength(25,ErrorMessage = "Name is required"),MaxLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public int ProductId  { get; set; }
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
        public string ImageName { get; set; }

        public Category MyCat { get; set; }

        public IList<Provider> MyProviders { get; set; }
        [ForeignKey("MyCat")]
        public int? CategoryId { get; set; }
        public override void GetDetails()
        {
            System.Console.WriteLine("Name : " + Name);
        }
        public virtual string GetMyType()
        {
            return ("My type :  UNKNOWN");
        }
    }
}

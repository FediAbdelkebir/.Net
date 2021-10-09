using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Product:Concept
    {
        public DateTime DateProd { get; set; }
        public String  Description { get; set; }
        public String Name { get; set; }
        public Double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Category Mycategory { get; set; }

        public IList<Provider> Providers { get; set; }

        
            public override void GetDetails()
        {
            System.Console.WriteLine(" UserName: " + Name);
        }
        public virtual string GetType()
        {
            return("Type : UNKNOWN");
        }
    }
    
}

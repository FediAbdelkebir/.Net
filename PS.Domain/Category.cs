using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PS.Domain
{
  public  class Category:Concept

    {
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual IList<Product> Products { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Name:" + Name + "; CategoryId:" + CategoryId);
        }
    }
}
 
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
   public class Chemical: Product
    { 
        public string LabName { get; set; }
        public Address MyAddress { get; set; }
        public override void GetMyType()
        {
            Console.WriteLine("Chemical");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Biological:Product
    {
        public string Herbs { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Herbs  : " + Herbs );
        }
        public override string GetMyType()
        {
            return ("My type :  BIOLOGICAL");
        }
    }
}

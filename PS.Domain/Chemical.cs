using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemical:Product //il n'y a pas d'héritage multiple de classe 
    {
        public string LabName { get; set; }
        public Address MyAddress { get; set; }

        public override void GetDetails()
        {
            base.GetDetails();
            System.Console.WriteLine("LabName: " + LabName);
        }

        public override string GetMyType()
        {
            return "My type : CHEMICAL" ;
        }
    }
}

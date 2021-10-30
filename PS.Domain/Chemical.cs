using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemical:Product
    {
        public string LabName { get; set; }
        public Address MyAddress { get; set; }
        public override void GetDetails()
        {
            System.Console.WriteLine("city : " + MyAddress.City + " , Lab name :" + LabName + " , Street Add : " + MyAddress.StreetAddress);
        }
        public override string GetMyType()
        {
            return ("My type :  CHEMICAL");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemical:Product 
    {
        public String City { get; set; }
        public String LabName { get; set; }
        public String StreetAddress { get; set; }

        public override void GetDetails()
        {
            base.GetDetails();
            System.Console.WriteLine(" LabName ; " + LabName);
        }

    }
}

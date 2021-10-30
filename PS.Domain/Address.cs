using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    [Owned]
    public class Address
    {
        
        public string City { get; set; }
        public string StreetAddress {get;set;}
    }
}

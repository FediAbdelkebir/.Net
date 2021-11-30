
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{[Owned]
    public class Address
    {
        //type complexe ou d'entité détenus : n'a pas de clé primaire 
        public string StreetAddress { get; set; }
        public string City { get; set; }

    }
}

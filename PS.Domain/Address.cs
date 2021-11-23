using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    [Owned]
    public class Address
    {
        [Required]
        [Column("MyCity")]
        public string City { get; set; }
        [MaxLength(50)]
        [Column("MyStreet")]
        public string StreetAddress { get; set; }
    }
}

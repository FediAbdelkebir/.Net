using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Client
    {
        //[ForeignKey("Client")] //nom de var ds facture
        [Key]
        public int CIN { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }

        public virtual IList<Facture> Factures { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}

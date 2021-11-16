using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PS.Domain
{
    public class Client
    {[Key]
        public int CIN {get; set;}
        public DateTime DateNaissance {get; set;}
        public string Name { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public virtual IList<Facture> Factures { get; set; }
    }
}

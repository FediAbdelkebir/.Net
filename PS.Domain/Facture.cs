using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Facture
    {
        public int ClientFk { get; set; }
        public int ProductFK { get; set; }
        public DateTime DateAchat { get; set; }
        public int Prix { get; set; }

        //1 client et many factures
        //[ForeignKey("ClientFK")] //nom de clé qui correpsond au client
        public virtual Client Client { get; set; }

        //[ForeignKey("ProductFK")] //ou bien on peut aussi l'ajouter dans client
        public virtual Product Product { get; set; }
    }
}

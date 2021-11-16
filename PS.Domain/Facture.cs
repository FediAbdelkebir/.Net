using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Facture
    {
        public int ClientFK { get; set; }
        public int ProductFk { get; set; }
        public DateTime DateAchat {get; set; }
        public int Prix {get; set;}
        [ForeignKey("ClientFK")]
        public virtual Client Client { get; set; }
        [ForeignKey("ProductFK")]
        public virtual Product Product { get; set; }
    }
}

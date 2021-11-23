using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
   public class Facture
     {   
        
        public DateTime DateAchat { get; set; }
       
        public int ProductFk { get; set; }
        public int ClientFk { get; set; }
        public int Prix { get; set; }
        //prop de navigation
        //[ForeignKey("ClientFk")]
        public virtual Client Client { get; set; }
        //[ForeignKey("ProductFk")]
        public virtual Product Product { get; set; }
    }

}


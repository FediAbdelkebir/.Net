using PS.Data.Infrastructures;
using PS.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service
{
    public class FactureService : Service<Facture>, IFactureService
    {
        private readonly IUnitOfWork utwk;
        public FactureService(IUnitOfWork utwk) : base(utwk)
        {

        }
    }
}

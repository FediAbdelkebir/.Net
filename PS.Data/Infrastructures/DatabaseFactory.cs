using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Infrastructures
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private PSContexte dataContext;
        public PSContexte DataContext
        {
            get { return dataContext; }
        }
        public DatabaseFactory() { dataContext = new PSContexte(); }
        protected override void DisposeCore()
        {
            if (dataContext != null) // si existe déja une instance
                dataContext.Dispose(); // fermer cnx avec bd , libérer mémoire 
        }
    }
}

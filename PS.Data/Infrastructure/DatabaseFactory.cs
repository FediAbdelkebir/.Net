using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Infrastructure
{
   public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private PSContext dataContext;
        public PSContext DataContext
        {
            get { return dataContext; }
        }
        public DatabaseFactory() { dataContext = new PSContext(); }
        protected override void DisposeCore()
        {
            if (dataContext != null)//si existe une instance
                dataContext.Dispose();//ferler cnx avec bd,libérer memoire
        }
    }
}

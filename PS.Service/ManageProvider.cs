using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ps.Service
{
    public class ManageProvider
    {
        public IList<Provider> Providers;
        public ManageProvider(IList<Provider> providers)
        {
            this.Providers = providers;
        }
        public IList<Provider> GetProviderByName(string name)
        {
            var query = from p in Providers where p.UserName == name select p;
            return query.ToList();
        }

        //Methode 2 :
        public IEnumerable<Provider> GetProviderByName2(string name)
        {
            var query = from p in Providers where p.UserName == name select p;
            return query;
        }
        //2eme point Partie2.1
        public Provider GetFirstProvider(string name)
        {
            var query = from p in Providers
                        where p.UserName == name
                        select p;
            return query.FirstOrDefault();
        }

        //3eme point Partie2.1
        public Provider GetProviderById(int id)
        {
            var query = from p in Providers
                        where p.Id == id
                        select p;
            return query.SingleOrDefault();

        }
    }
}

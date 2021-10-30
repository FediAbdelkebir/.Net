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

        public ManageProvider(IList<Provider> Providers)
        {
            this.Providers = Providers;
                
        }

        public IList<Provider> GetProviderByName( string name)
        {
            var query = from p in Providers where p.Username == name select p;
            return query.ToList();

        }
        //method 2
        public IEnumerable<Provider> GetProviderByName2(string name)
        {
            var query = from p in Providers where p.Username == name select p;
            return query;

        }

        public Provider GetFirstProviderByName(string name)
        {
            var query = from p in Providers where p.Username == name select p;
            return query.FirstOrDefault();

        }


        public Provider GetProviderById(int id)
        {
            var query = from p in Providers where p.Id == id select p;
            return query.SingleOrDefault();//ordefault pour eviter une exception si il n a pas trouver aucun elément

        }
    }
}

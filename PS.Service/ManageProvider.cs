using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service
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
            var req = from p in Providers where p.UserName == name select p;
            return req.ToList();
        }

        public IEnumerable<Provider> GetProviderByName2(string name)
        {
            var req = from p in Providers where p.UserName == name select p;
            return req;
        }

        public Provider GetFirstProviderByName(string name)
        {
            var req = from p in Providers where p.UserName == name select p;
            return req.FirstOrDefault();
            //return req.First();
            //firstOrDefault : first sinon un element par défaut
        }

        public Provider GetProviderById(int id)
        {
            var req = from p in Providers where p.Id == id select p;
            return req.SingleOrDefault();
        }
    }
}

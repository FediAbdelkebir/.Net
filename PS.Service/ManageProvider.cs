using System;
using System.Collections.Generic;
using System.Text;
using PS.Domain;
using System.Linq;
namespace PS.Service
{
    class ManageProvider
    {/**Ne9sa T3abbi el Liste*/

        public IList<Provider> Providers;

        public ManageProvider(IList<Provider> P)
        {
        this.Providers = P;
        }
        /*public IList<Provider> GetProviderByName(String Name)
        {
            return P.FindAll(e => e.UserName.Equals(Name));
            
            var req = from p in Providers where p.UserName == Name select p;
            return req.ToList();
        }*/
        public IEnumerable<Provider> GetProviderByName(String Name)
        {
         //   return P.FindAll(e => e.UserName.Equals(Name));
            
            var req = from p in Providers where p.UserName == Name select p;
            return req;
        }

        public Provider GetFirstProviderByName(String Name)
        {
            var req = from p in Providers where p.UserName == Name select p;
            return req.FirstOrDefault();
        }

        public Provider GetProviderById(int id)
        {
            var req = from p in Providers where p.id== id select p;
            return req.SingleOrDefault();
            
        }
    }
}

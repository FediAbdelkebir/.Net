using System;
using System.Collections.Generic;
using System.Text;
using PS.Domain;
namespace PS.Service
{
    class ManageProvider
    {/**Ne9sa T3abbi el Liste*/
        List<Provider> P = new List<Provider>(){};

        public List<Provider> GetProviderByName(String Name)
        {
            return P.FindAll(e => e.UserName.Equals(Name));
        }
        public List<Provider> GetFirstProviderByName(String Name)
        {/**Ne9sa first */
            return P.FindAll(e => e.UserName.Equals(Name));
        }
        public Provider GetProviderById(int id)
        {
            return P.Find(e => e.id.Equals(id));
        }
    }
}

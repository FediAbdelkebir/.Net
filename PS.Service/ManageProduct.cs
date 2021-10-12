using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PS.Domain;
namespace PS.Service
{
    class ManageProduct
    {
        public IList<Product> Product;
        public ManageProduct(IList<Product>P)
        {
            this.Product = P;

        }
        public IEnumerable<Chemical> Get5Chemical(double price)
        {/**Ne9sa filtre 5*/
            var req = from p in Product where p.Price > price && p is Chemical select p;
            return (IEnumerable<Chemical>)req.Take(5);
        }
        public IEnumerable<Product> GetProductPrice(double price)
        {
            var req = from p in Product where p.Price > price select p;
            return req.Skip(2);
        }
        public double GetAvaragePrice()
        {
            var req = from p in Product select p.Price;
            return req.Average();
        }
        public Product GetMaxPrice()
        {
            var req = from p in Product select p;
            var query = from p in Product where (p.Price.Equals(req.Max())) select p;
            return query.FirstOrDefault();
        }
        public int GetCountProduct(string city)
        {
            var req = from p in Product where ((Chemical)p).City.Equals(city) select p ;
            return req.Count();
        }
        public IEnumerable<Product> GetChemicalCity()
        {/**Ne9sa Order By City**/
            var req = from p in Product orderby ((Chemical)p).City select p ;
            return req;
        }
        public void GetChemicalGroupByCity() {
            var req = from p in Product orderby ((Chemical)p).City group p by ((Chemical)p).City;
            foreach(var group in req)
            {
                System.Console.WriteLine(group.Key);
                foreach(var i in group)
                {
                    i.GetDetails();
                }
            }
        }
        /** Ma 3rfthech**/
        Func<List<Product>, String> FindProduct = e =>
        {
            return P.FindAll(e => e.Mycategory.Name.Equals("Chemical")); ;
        };
        Func<List<Product>, String> ScanProduct = Cat =>
        {
            return P.FindAll(e => e.Mycategory.Name.Equals(Cat));
        };
    }
}

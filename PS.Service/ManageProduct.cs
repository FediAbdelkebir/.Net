using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service
{
    public class ManageProduct
    {
        public IList<Product> Products;

        public ManageProduct(IList<Product> products)
        {
            this.Products = products;
        }

        public IEnumerable<Chemical> Get5Chemical(double price)
        {
            var req = from p in Products where p.Price > price && p is Chemical select p;
            return (IEnumerable<Chemical>)req.Take(5);
        }

        public IEnumerable<Chemical> Get5Chemical2(double price)
        {
            var req = from p in Products where p.Price > price && p is Chemical select p;
            return req.OfType<Chemical>().Take(5);
        }

        public IEnumerable<Product> GetProductPrice(double price)
        {

            var req = from p in Products where p.Price > price select p;
            return req.Skip(2);
        }

        public double GetAveragePrice()
        {
            var req = from p in Products select p.Price;
            return req.Average();
        }

        public Product GetMaxPrice()
        {
            var req = from p in Products select p.Price;
            double price = req.Max();
            var req2 = from p in Products where p.Price == price select p;
            return req2.FirstOrDefault();
        }

        public int GetProductCount(string city)
        {
            var req = from p in Products where ((Chemical)p).MyAddress.City == city select p;
            return req.Count();
        }

        public IEnumerable<Product> GetChemicalCity()
        {
            var req = from p in Products orderby ((Chemical)p).MyAddress.City select p;
            return req;
        }

        public void GetChamicalGroupByCity()
        {
            var req = from p in Products
                      orderby ((Chemical)p).MyAddress.City
                      group p by ((Chemical)p).MyAddress.City;
            foreach(var grp in req)
            {
                Console.WriteLine(grp.Key);
                foreach(var i in grp)
                {
                    i.GetDetails();
                }

            }
        }

    }
}

using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ps.Service
{
    public class ManageProduct
    {
        IList<Product> Prods;
        public ManageProduct(IList<Product> prods)
        {
            this.Prods = prods;
        }

        //4eme point Partie2.1
        public IEnumerable<Chemical> Get5Chemical(double price)
        {
            var query = from p in Prods
                        where p.Price > price && p is Chemical
                        select p;
            return (IEnumerable<Chemical>)query.Take(5);
            //ou bien 
            // return query.OfType<Chemical>().Take(5);
        }

        //5eme point Partie2.1
        public IEnumerable<Product> GetProductPrice(double price)
        {
            var query = from p in Prods
                        where p.Price > price
                        select p;
            return query.Skip(2);
        }

        //6eme point Partie2.1
        public double GetAveragePrice()
        {
            var query = from p in Prods select p.Price;
            return query.Average();
        }

        //7eme point Partie2.1
        public Product GetMaxPrice()
        {
            var query1 = from p in Prods select p.Price;
            var query = from p in Prods
                        where (p.Price == query1.Max())
                        select p;
            return query.FirstOrDefault();
        }

        //8éme point Partie2.1
        public int GetCountProduct(string city)
        {
            var query = from p in Prods
                        where ((Chemical)p).MyAddress.City == city
                        select p;
            return query.Count();
        }

        //9éme point Partie2.1
        public IEnumerable<Product> GetChemicalCity()
        {
            var query = from p in Prods
                        orderby ((Chemical)p).MyAddress.City
                        select p;
            return query;
        }

        //10éme point Partie2.1
        public void GetChemicalGroupByCity()
        {
            var query = from p in Prods
                        orderby ((Chemical)p).MyAddress.City
                        group (Chemical)p by ((Chemical)p).MyAddress.City;
            foreach (var grp in query)
            {
                Console.WriteLine(grp.Key);
                foreach (var i in grp)
                {
                    i.GetDetails();
                }
            }
        }

    }
}

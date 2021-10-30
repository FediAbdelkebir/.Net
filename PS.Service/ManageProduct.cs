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

        public ManageProduct(IList<Product> Prods)
        {
            this.Prods = Prods;   
        }
        public IEnumerable<Chemical> Get5Chemical(double price)
        {
            var query = from p in Prods where p.Price >price && p is Chemical select p;
            return (IEnumerable<Chemical>)query.Take(5);

        }

        //method2

        public IEnumerable<Chemical> Get5Chemical2(double price)
        {
            var query = from p in Prods where p.Price > price && p is Chemical select p;
            return query.OfType<Chemical>().Take(5);// oftype car sont des chemical de type product puisque p in prods

        }
        //pour eliminer le deux premier elements
        public IEnumerable<Product> GetProductPrice(double price)
        {
            var query = from p in Prods where p.Price > price select p;
            return query.Skip(2);

        }
        //Average(moyenne)
        public double GetAveragePrice()
        {
            var query = from p in Prods select p.Price;
            return query.Average();

        }

        //max
        public Product GetMaxPrice()
        {
            var query1 = from p in Prods select p.Price;//requete feha liste des prix
            var query = from p in Prods where(p.Price == query1.Max()) select p;//on a appliquer max sur la 1er liste
            return query.FirstOrDefault();

        }
        //retourne le nombre de chemical selon le nom de city
        public int GetCountProduct(string city)
        {
            var query = from p in Prods where ((Chemical)p).MyAddress.City == city select p;
            return query.Count();

        }
        //retourne la liste des prods chemicals ordonnées par city
        public IEnumerable<Product> GetChemicalCity()
        {
            var query = from p in Prods orderby ((Chemical)p).MyAddress.City select p;//caster produit de type chemical
            return query;

        }

        //retourne la liste des prods chemicals ordonnées par city et group by city
        public void GetChemicalGroupByCity()
        {
            var query = from p in Prods
                        orderby ((Chemical)p).MyAddress.City
                        group (Chemical)p by ((Chemical)p).MyAddress.City;
                    foreach(var grp in query)
            {
                Console.WriteLine(grp.Key);//key c'est city
                foreach(var i in grp)
                {
                    i.GetDetails();
                }
            }
    

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PS.Domain;
namespace PS.Service
{
    class ManageProduct
    {
        /**Ne9sa T3abbi el Liste*/
        List<Product> P = new List<Product>() { };
        public List<Product> Get5Chemical(double price)
        {/**Ne9sa filtre 5*/
            return P.FindAll(e => e.Price>price);
        }
        public List<Product> GetProductPrice(double price)
        {
            return P.FindAll(e => e.Price > price);
        }
        public double GetAvaragePrice()
        {
            return P.Average(e=>e.Price);
        }
        public Product GetMaxPrice()
        {
            double Max=P.Max(e => e.Price);
            return P.Find(e => e.Price.Equals(Max));
        }
        public int GetCountProduct(string city)
        {
            List<Product> List = P.FindAll(e => e.City.Equals(city));
            return List.Count();
        }
        public List<Product> GetChemicalCity()
        {/**Ne9sa Order By City**/
            return P.FindAll(e => e.Mycategory.Name.Equals("Chemical"));
        }
        public List<Product> GetChemicalGroupByCity() {

            return P.FindAll(e => e.Mycategory.Name.Equals("Chemical"));
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

using PS.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service
{
    public interface IProductService : IService<Product>
    {
        //public void Add(Product p);
        //public void Remove(Product p);
        //public IList<Product> GetAll();
        public IEnumerable<Product> FindMost5ExpensiveProds(double price);
        public float UnavailableProductsPercentage();
        public IEnumerable<Product> GetProdsByClient(Client c);
    }
}

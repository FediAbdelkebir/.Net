using PS.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service
{
    public interface IProductService : IServices<Product>
    {
        //public void Add(Product p);
        //public void Remove(Product p);
        public IEnumerable<Product> FindMost5ExpensiveProds();
        public float UnavailableProductsPercentage();
        public IEnumerable<Product> GetProdsByClient(Client c);
        //public IEnumerable<Product> GetAll ();
        //Replaced with IService
    }
}

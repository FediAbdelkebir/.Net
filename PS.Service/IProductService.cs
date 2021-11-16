using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service
{
    public interface IProductService
    {
        public void Add(Product p);
        public void Remove(Product p);
        public IList<Product> GetAll();


    }
}

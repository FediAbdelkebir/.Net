using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ps.Service
{
    interface IProductService
    {
        public void Add(Product P);
        public void Remove(Product P);
        public IEnumerable<Product> GetAll();
    }
}

using PS.Data;
using PS.Data.Infrastructure;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ps.Service
{
    public class ProductService : IProductService
        
    {
        static IDatabaseFactory context = new DatabaseFactory();
        IRepositoryBase<Product> repo = new RepositoryBase<Product>(context);
        public void Add(Product P)
        {
            //context.DataContext.Products.Add(P);
            //Sauvegarder Les Données
            repo.Add(P);
            context.DataContext.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            //return context.DataContext.Set<Product>().ToList();
            return repo.GetAll();
        }

        public void Remove(Product P)
        {
            //context.DataContext.Remove(P);
            //Sauvegarder Les Données
            repo.Delete(P);
            context.DataContext.SaveChanges();
        }
    }
}

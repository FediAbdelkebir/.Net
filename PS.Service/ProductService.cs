
using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service
{
    public class ProductService : IProductService
    {
        static IDatabaseFactory contexte = new DatabaseFactory();
        //PSContexte contexte = new PSContexte();
        IRepositoryBase<Product> repo = new RepositoryBase<Product>(contexte);
        public void Add(Product p)
        {
            //contexte.DataContext.Products.Add(p);
            //contexte.DataContext.SaveChanges();

            //contexte.Products.Add(p);
            //contexte.SaveChanges();

            repo.Add(p);
            contexte.DataContext.SaveChanges();

        }

        public IList<Product> GetAll()
        {
            //return contexte.DataContext.Products.ToList();
            //return contexte.DataContext.Set<Product>().ToList();
            //return contexte.Products.ToList();
            return repo.GetAll().ToList();
        }

        public void Remove(Product p)
        {
            //contexte.DataContext.Products.Remove(p);
            //contexte.Remove(p);

            repo.Delete(p);
            contexte.DataContext.SaveChanges();
        }
    }
}

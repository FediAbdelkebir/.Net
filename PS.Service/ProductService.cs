
using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IUnitOfWork utwk;
        public ProductService(IUnitOfWork utwk) : base(utwk)
        {

        }
        public IEnumerable<Product> FindMost5ExpensiveProds(double price)
        {
            /*IList<Product> prods = new List<Product>();
            var req = from p in prods
                      orderby p.Price ascending
                      select p;
            return req.Take(5);*/

            return GetMany()
                .OrderByDescending(p => p.Price).
                Take(5);
        }

        public float UnavailableProductsPercentage()
        {
            return ((float)GetMany(p => p.Quantity == 0).Count() / GetMany().Count()) * 100 ;
        }

        public IEnumerable<Product> GetProdsByClient(Client c)
        {
            IFactureService fs = new FactureService(utwk);
            return (fs.GetMany(f => f.ClientFk == c.CIN).Select(f => f.Product));
        }

        public void DeleteOldProducts()
        {
            var req = GetMany(p => (DateTime.Now - p.DateProd).TotalDays > 365);
            foreach(Product p in req)
            {
                Delete(p);
                Commit();
            }
        }


        /*static IDatabaseFactory contexte = new DatabaseFactory();
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
        }*/
    }
}

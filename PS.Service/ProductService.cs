using PS.Data;
using PS.Data.Infrastructure;
using PS.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PS.Service
{
    public class ProductService : Service<Product> ,   IProductService
    {
        //static IDatabaseFactory factory = new DatabaseFactory();
        ////IRepositoryBase<Product> repo = new RepositoryBase<Product>(factory);
         //IUnitOfWork uow = new UnitOfWork(factory);
        //public void Add(Product p)
        //{
        //    uow.getRepository<Product>().Add(p);
        //    uow.Commit();
        //}
        //public IEnumerable<Product> GetAll()
        //{
        //    return uow.getRepository<Product>().GetAll();
        //}
        //public void Remove(Product p)
        //{
        //    uow.getRepository<Product>().Delete(p);
        //    uow.Commit();
        //
        
        
        
        
        public IEnumerable<Product> FindMost5ExpensiveProds()
        {
            //IList<Product> prods = new List<Product>();
            //    var query = from p in prods
            //                orderby p.Price descending
            //                select p;
            //    return query.Take(5);
            return GetMany().OrderByDescending(p => p.Price).Take(5);
        }
        public float UnavailableProductsPercentage()
        {
            return ((float)GetMany(p => p.Quantity == 0).Count() / GetMany().Count()) * 100;
        }
        public IEnumerable<Product> GetProdsByClient(Client c)
            
        {
            IFactureService fs = new FactureService();
            return (fs.GetMany(f => f.ClientFk == c.CIN).Select(f => f.Product));
        }
        public void DeleteOldProducts()
        {

           var req = GetMany(p => (DateTime.Now - p.DateProd).TotalDays > 365 );
            foreach (Product p in req)
            {
                Delete(p);
                Commit();
            }
            
        }


    }
}

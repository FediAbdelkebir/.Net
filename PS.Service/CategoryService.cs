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
    public class CategoryService : Service<Category>, ICategoryService
    {
        //    static IDatabaseFactory factory = new DatabaseFactory();
        //    IRepositoryBase<Category> repo = new RepositoryBase<Category>(factory);
        //    IUnitOfWork uow = new UnitOfWork(factory);
        //    public void Add(Category c)
        //    {
        //        uow.getRepository<Category>().Add(c);
        //        uow.Commit();
        //    }
        //    public void Remove(Category c)
        //    {
        //        uow.getRepository<Category>().Delete(c);
        //        uow.Commit();
        //    }
        //    public IEnumerable<Category> GetAll()
        //    {
        //        return uow.getRepository<Category>().GetAll();
       // Replaced with  ***IServices and Service ****
        //}
    }
}

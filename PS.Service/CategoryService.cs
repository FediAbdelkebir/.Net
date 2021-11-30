using PS.Data;
using PS.Data.Infrastructures;
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
        private readonly IUnitOfWork utwk;
        public CategoryService(IUnitOfWork utwk) :base(utwk)
        {

        }
        /*static DatabaseFactory factory = new DatabaseFactory();
        //IRepositoryBase<Category> repo = new RepositoryBase<Category>(factory);
        IUnitOfWork uow = new UnitOfWork(factory);
        public void Add(Category c)
        {
            //factory.DataContext.Categories.Add(c);
            //factory.DataContext.SaveChanges();

            //repo.Add(c);
            uow.getRepository<Category>().Add(c);
            //factory.DataContext.SaveChanges();
            uow.Commit();
        }

        public IList<Category> GetAll()
        {
            // return factory.DataContext.Categories.ToList();

            //return repo.GetAll().ToList();
            return uow.getRepository<Category>().GetAll().ToList();
        }

        public IEnumerable<Category> GetAll2()
        {
            // return factory.DataContext.Categories.ToList();
            //return repo.GetAll();
            return uow.getRepository<Category>().GetAll();
        }

        public void Remove(Category c)
        {
            //factory.DataContext.Categories.Remove(c);

            //repo.Delete(c);
            uow.getRepository<Category>().Delete(c);
            //factory.DataContext.SaveChanges();
            uow.Commit();
        }*/

    }
}

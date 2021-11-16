using PS.Data;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Data.Infrastructure;
using System.Linq.Expressions;
namespace Ps.Service
{
   public class CategoryService :ICategoryService
    {
        static DatabaseFactory context = new DatabaseFactory();
        IRepositoryBase<Category> repo = new RepositoryBase<Category>(context);
        public void Add(Category C)
        {
            repo.Add(C);
            context.DataContext.SaveChanges();
        }

        public void Delete(Category entity)
        {
            repo.Delete(entity);
            context.DataContext.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            //return context.DataContext.Categories.ToList();
            return repo.GetAll();
        }

        public Category GetById(long Id)
        {
            throw new NotImplementedException();
        }
        public void Remove(Category C)
        {
            context.DataContext.Remove(C);
            context.DataContext.SaveChanges();
        }
    }
}

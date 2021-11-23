using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Data.Infrastructure
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private IDatabaseFactory _dbFactory;
        DbSet<T> dbset
        {
            get
            {
                return _dbFactory.DataContext.Set<T>();
            }
        }
        public RepositoryBase(IDatabaseFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public virtual void Delete(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();

            foreach (T obj in objects)
                
                dbset.Remove(obj);

        }

        public virtual T Get(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.AsEnumerable();
        }

        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }

        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetMany(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            IQueryable<T> mydbset = dbset;
            if (where != null)
                mydbset = mydbset.Where(where);
            return mydbset.AsEnumerable();
        }

        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            _dbFactory.DataContext.Entry(entity).State = EntityState.Modified;
        }
    }
}

using PS.Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ServicePattern
{
    public class Service<T> : IService<T> where T : class
    {
        static IDatabaseFactory factory = new DatabaseFactory();
        //static IUnitOfWork utwk = new UnitOfWork(factory);
        //ctor double tab

        private readonly IUnitOfWork utwk;
        public Service(IUnitOfWork utwk)
        {
            this.utwk = utwk;
        }
    public virtual void Add(T entity)
    {
        utwk.getRepository<T>().Add(entity);
    }
    public virtual void Update(T entity)
    {
        utwk.getRepository<T>().Update(entity);
    }
    public virtual void Delete(T entity)
    {
        utwk.getRepository<T>().Delete(entity);
    }
    public virtual void Delete(Expression<Func<T, bool>> where)
    {
        utwk.getRepository<T>().Delete(where);
    }
    public virtual T GetById(long id)
    {
        return utwk.getRepository<T>().GetById(id);
    }
    public virtual T GetById(string id)
    {
        return utwk.getRepository<T>().GetById(id);
    }
    public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null)
    {
        return utwk.getRepository<T>().GetMany(filter);
    }
    public virtual T Get(Expression<Func<T, bool>> where)
    {
        return utwk.getRepository<T>().Get(where);
    }
    public virtual void Dispose()
    {
        utwk.Dispose();
    }
    public void Commit()
    {
        try
        {
            utwk.Commit();
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
}

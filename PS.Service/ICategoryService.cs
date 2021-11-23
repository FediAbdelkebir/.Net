using PS.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service
{
    public interface ICategoryService : IServices<Category>
    {
        //public void Add(Category c);
        //public void Remove(Category c);

        //public IEnumerable<Category> GetAll();
        
        //*****replaced with IServices****
    }
}

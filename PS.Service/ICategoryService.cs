using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ps.Service
{
    interface ICategoryService
    {
        public void Add(Category C);
        public void Remove(Category C);
        public IEnumerable<Category> GetAll();
    }
}

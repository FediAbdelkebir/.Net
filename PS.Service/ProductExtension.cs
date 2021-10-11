using System;
using System.Collections.Generic;
using System.Text;
using PS.Domain;
namespace PS.Service
{
    class ProductExtension:ManageProduct
    {

        public String UpperName(Product P)
        {
            return P.Name.ToUpper();
        }
        public bool InCategory(Category C,Product P)
        {
            if (C.Products.Contains(P))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

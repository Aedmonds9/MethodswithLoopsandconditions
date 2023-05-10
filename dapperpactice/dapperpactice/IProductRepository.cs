using System;
using System.Collections.Generic;
using System.Text;

namespace DapperInClass
{
    public interface IProductRepository
    {
        public IEnumerable<Products> GetAllProducts();

        public void CreateProduct(string name, double price, int categoryID);
    }

    
    

}

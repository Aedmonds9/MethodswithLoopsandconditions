using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperInClass
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository( IDbConnection connection)
        {
            _connection = connection;
        }

         public IEnumerable<Products> GetAllProducts()
        {
          return _connection?.Query<Products>("SELECT * FROM PRODUCTS;");

        }
        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection?.Execute("INSERT INTO PRODUCTS (Name, Price, CategoryID) VALUES ( @name, @price, @categoryID);",
                new {name = name, price = price, categoryID = categoryID });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DapperInClass
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public string StockLevel { get; set; }
        public object Name { get; internal set; }
    }
}

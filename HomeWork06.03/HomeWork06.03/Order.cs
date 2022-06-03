using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork06._03
{
    class Order:Product
    {
        public Order()
        {

        }
        public Order(string name, int id, decimal totalprice,int productcount)
        {
            Name = name;
            ID = id;
            TotalPrice = totalprice;
            ProductCount = productcount;
        }
        public int ID { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductCount { get; set; }
    }
}

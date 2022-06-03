using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork06._03
{
    class Cart:Order
    {
        public Cart(int id, int ordernumber)
        {
            Id = id;
            OrderNumber = ordernumber;

        }
        public int Id { get; set; }
        public int OrderNumber { get; set; }
    }
}

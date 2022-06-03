using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork06._03
{
    class Product
    {
        public Product()
        {
                
        }
        public Product(int id, string name, decimal price, string color, decimal size,string type)
        {
            ID = id;
            Name = name;
            Price = price;
            Color = color;
            Size = size;
            Type = type;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public decimal Size { get; set; }
        public string Type { get; set; }
    }
}

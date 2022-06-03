using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork06._03
{
    class Customer:Person
    {
        public Customer(string name, string surname, string customernumber)
        {
            Name = name;
            Surname = surname;
            CustomerNumber = customernumber;
        }
        public string CustomerNumber { get; set; }
        public string CustomerType { get; set; }
    }
}

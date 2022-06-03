using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork06._03
{
    class Employee:Person
    {
        public Employee(string name, string surname, string empNumber, decimal salary, string position)
        {
            Name = name;
            Surname = surname;
            EmployeeNumber = empNumber;
            Salary = salary;
            Position = position;
        }
        public string EmployeeNumber { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
    }
}

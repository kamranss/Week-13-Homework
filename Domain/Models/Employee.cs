using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        static int count;

        public Employee(int age, int salary, string name)
        {
            count = 0;
            Id = ++count;
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}

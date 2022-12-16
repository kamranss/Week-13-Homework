using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee:Person
    {
        public int Id { get; private set; }
        public int Age { get; set; }

        static int count;

        static Employee()
        {
            count = 0;
        }
        public Employee(int age, int salary, string name)
        {
            
            Id = ++count;
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Person
    {
        public int Id { get; private set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Address { get; set; }
        public int Salary { get; set; }
        public int id_no = 0;
        public Person()
        {
            id_no++;
            Id = id_no;
        }
    }
}

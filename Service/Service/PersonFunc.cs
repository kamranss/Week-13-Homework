using Domain.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class PersonFunc : IPersonFunc
    {

        public bool Check(Person person)
        {
            return person.Salary > 1000;
        }

        private List<Person> peopleinfo()
        {
            Person person1 = new Person();
            person1.Name = "Elman";
            person1.Surname = "Samadov";
            person1.Salary = 2110;
            person1.Address = "Sovket Memmedov 3";

            Person person2 = new Person();
            person2.Name = "Ali";
            person2.Surname = "Huseynov";
            person2.Salary = 1200;
            person2.Address = "Yusif Safarov 6";

            Person person3 = new Person();
            person2.Name = "Sabir";
            person2.Surname = "Huseyn";
            person2.Salary = 1900;
            person2.Address = "Suleyman Sani Axundov 3";

            List<Person> list = new List<Person>();
            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            return list;
        }
        public void ShowPersonInfo(Predicate<Person> function)
        {
            

            foreach (var item in peopleinfo())
            {
                if (function(item))
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Salary);
                    Console.WriteLine(item.Address);
                }
            }

            


        }
    }
}

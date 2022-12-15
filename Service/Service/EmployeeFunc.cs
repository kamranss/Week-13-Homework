using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class EmployeeFunc : IEmployeeFunc
    {


        #region Old version
        //public delegate bool Check(int m);
        //public bool IsEven(int m)
        //{
        //    return m %2==0;
        //}

        //public bool Check(Employee a)
        //{
        //    List<Employee> employees = new List<Employee>();
        //    if (employees.Count)
        //    {

        //    }
        //}
        #endregion

        //Action<string, string, int> Functions = (a, b, c) => { Console.WriteLine(); };
        public void SumAvgSalary()
        {
            Employee employee1 = new Employee(19, 4000, "Kamran");
            Employee employee2 = new Employee(27, 1500, "Kamil");
            Employee employee3 = new Employee(23, 2360, "Sahil");

            List<Employee> employees = new List<Employee>();

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

            List<Employee> identifiedemployess = employees.FindAll(employee => employee.Age > 20 && employee.Age < 40);

            Console.WriteLine(identifiedemployess.Average(employee => employee.Salary));
        }
    }
}

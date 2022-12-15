// See https://aka.ms/new-console-template for more information



using Domain.Models;
using Service.Service;

#region Lamda expression Delegates --- 
// Identifing Sum of the average salaries employees within the list considering that their age shoud be between 20 and 40 
EmployeeFunc iteration = new EmployeeFunc();

iteration.SumAvgSalary();
Console.WriteLine("----------------------------------------");
#endregion

#region Using Lmbda expression, delegate and anonymous method --- Find person who has salary more than 1000
PersonFunc personFunc  = new PersonFunc();

personFunc.ShowPersonInfo(person => person.Salary > 1000);

Console.WriteLine("----------------------------------------");

personFunc.ShowPersonInfo(delegate (Person person) { return person.Salary > 1000; });

Console.WriteLine("----------------------------------------");
personFunc.ShowPersonInfo(personFunc.Check);

Console.WriteLine("----------------------------------------");
#endregion


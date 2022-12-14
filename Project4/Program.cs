// See https://aka.ms/new-console-template for more information



using Domain.Models;
using Service.Service;

#region Lamda expression Delegates
// Identifing Sum of the average salaries employees within the list considering that their age shoud be between 20 and 40 
EmployeeFunc iteration = new EmployeeFunc();

iteration.SumAvgSalary();
#endregion
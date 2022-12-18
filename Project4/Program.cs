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
personFunc.ShowPersonInfo(person => person.Name== "Elman");
Console.WriteLine("----------------------------------------");

personFunc.ShowPersonInfo(delegate (Person person) { return person.Salary > 1000; });
Console.WriteLine("--");
personFunc.ShowPersonInfo(delegate (Person person) { return person.Name == "Elman"; });

Console.WriteLine("--");
Console.WriteLine("----------------------------------------");

personFunc.ShowPersonInfo(personFunc.Check);
Console.WriteLine("----------------------------------------");
#endregion

#region Show number of books according to the Author
Book book1 = new Book("Kamran Suleyman","Secrsts of Pandora");

Book book2 = new Book("Albert Jack", "Delicious Sandwich");

Book book3 = new Book("Albert Jack", "Beautiful Lazanya");

Book book4 = new Book("Kianu Rives", "Struggles of a Fatman");

Book book5 = new Book("Nizami", "Secrsts of Pandora");

BookFunc BookList = new BookFunc();
BookList.Books.Add(book1);
BookList.Books.Add(book2);
BookList.Books.Add(book3);
BookList.Books.Add(book4);
BookList.Books.Add(book5);

Console.WriteLine(BookList.Numberofbook(book => book.Author == "Nizami"));

#endregion
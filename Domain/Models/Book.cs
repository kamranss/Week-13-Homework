using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Book
    {
        public int Id { get;private set; }
        public string Author { get; set; }
        public string Name { get; set; }
        static int id_no;
        static Book()
        {
            id_no = 0;
        }
        #region This is key for calling other Ctors however within this you shoud send data types to other ctors
        public Book() : this("", "") { } //Default constructor
        #endregion
        public Book( string author, string name) // Cunstructor with parameters
        {
            id_no++;
            Id = id_no;
            Author = author;
            Name = name;
        }
    }
}

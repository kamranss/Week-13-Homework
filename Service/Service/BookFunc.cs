using Domain.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class BookFunc : IBookFunc
    {

        public List<Book> Books { get; set; }
        public BookFunc()
        {
            Books = new List<Book>();
        }

        public int Numberofbook(Predicate<Book> function)
        {
            //List<Book> BookList1 = new List<Book>();
            int count = 0;
            foreach (var item in Books)
            {
                if (function(item))
                {
                    count++;
                }
            }
            return count;
        }

       
    }
}

using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IBookFunc
    {
        public int Numberofbook(Predicate<Book> function);
    }
}

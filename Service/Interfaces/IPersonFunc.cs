﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IPersonFunc
    {
        public void ShowPersonInfo(Predicate<Person> function);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Andy", "Cullen", 26);

            person.PrintFullName();
            person.PrintFullName();
            person.PrintFullName();

        }
    }
}

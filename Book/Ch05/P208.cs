﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P208
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("코드 5-1");
            Random random = new Random();
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
        }
    }
}

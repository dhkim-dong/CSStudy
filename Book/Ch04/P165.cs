﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P165
    {
        static void Main20(string[] args)
        {
            Console.WriteLine("코드 4-11");
            string input;
            do
            {
                Console.Write("입력(exit을 입력하면 종료): ");
                input = Console.ReadLine();
            }
            while (input != "exit");
        }
    }
}

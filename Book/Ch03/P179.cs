﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P179
    {
        static void Main30(string[] args)
        {
            Console.WriteLine("코드 4-24");

            for (int i = 1; i < 10; i++)
            {
                if(i%2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

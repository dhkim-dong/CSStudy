﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._01단계
{
        internal class _01_08
        {
            static void Main8(string[] args)
            {
                string[] inputs = Console.ReadLine().Split();
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                Console.WriteLine((double)a/b);
            }
        }
}

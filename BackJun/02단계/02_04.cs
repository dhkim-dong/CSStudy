﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._02단계
{
    internal class _02_04
    {
        static void Main4(string[] args)
        {
            //Quardrant n = n사분면
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine(2);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
    }
}

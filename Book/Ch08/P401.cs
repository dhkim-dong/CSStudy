﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P401
    {
        static void Main1(string[] args)
        {
            Console.Write("숫자 입력: ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);

            if (result)
            {
                Console.WriteLine("입력한 숫자 " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요!");
            }
        }
    }
}

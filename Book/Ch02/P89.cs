﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P89
    {
        static void Main27(string[] args)
        {
            Console.WriteLine("코드 2-36 불 변수 생성");

            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);
        }
    }
}

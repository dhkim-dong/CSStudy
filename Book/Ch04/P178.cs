﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P178
    {
        static void Main29(string[] args)
        {
            Console.WriteLine("코드 4-23 goto 키워드");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto doNotUse;
                }
            }

        doNotUse:
            Console.WriteLine("goto 키워드"); // 안쓰는게 좋다. 쓰지말 것
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch10
{
    internal class P468
    {
        static void Main1(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());

            if(input < array.Length)
            {
                Console.WriteLine("입력한 위치의 값은 '" + array[input] + "'입니다.");
            }
            else
            {
                Console.WriteLine("인덱스 범위를 넘었습니다.");
            }

           
        }
    }
}

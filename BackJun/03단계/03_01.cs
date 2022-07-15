using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_01
    {
        static void Main1(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            // 입력받은 N단

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{input} * {i} = {input * i}");
            }
        }
    }
}

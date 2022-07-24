using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._07단계
{
    internal class _7_7
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if(N == 4 || N == 7)
            {
                Console.WriteLine(-1);
            }
            else if(N % 5 == 0)
            {
                Console.WriteLine(N / 5);
            }
            else if(N % 5 == 1)
            {
                Console.WriteLine((N / 5) + 1);
            }
            else if(N % 5 == 2)
            {
                Console.WriteLine((N / 5) + 2);
            }
            else if(N % 5 == 3)
            {
                Console.WriteLine((N / 5) + 1);
            }
            else
            {
                Console.WriteLine((N / 5) + 2);
            }
        }
    }
}

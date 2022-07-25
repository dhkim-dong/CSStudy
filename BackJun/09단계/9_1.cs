using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._09단계
{
    internal class _9_1
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(N));
        }

        static int Factorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}

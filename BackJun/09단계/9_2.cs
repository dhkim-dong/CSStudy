using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._09단계
{
    internal class _9_2
    {
        static void Main2(string[] args)
        {
            // n <= 20
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibo(N));
        }

        static int Fibo(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                return Fibo(n - 2) + Fibo(n - 1);
            } 
        }
    }
}

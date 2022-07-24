using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._07단계
{
    internal class _7_8
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            BigInteger A = BigInteger.Parse(inputs[0]);
            BigInteger B = BigInteger.Parse(inputs[1]);

            Console.WriteLine(A+B);
        }
    }
}

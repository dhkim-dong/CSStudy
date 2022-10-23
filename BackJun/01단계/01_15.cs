using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._01단계
{
    class _01_15
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);
            int d = int.Parse(inputs[3]);
            int e = int.Parse(inputs[4]);
            int f = int.Parse(inputs[5]);

            // 1,1,2,2,2,8

            int ta, tb, tc, td, te, tf;

            ta = 1 - a;
            tb = 1 - b;
            tc = 2 - c;
            td = 2 - d;
            te = 2 - e;
            tf = 8 - f;

            Console.WriteLine($"{ta} {tb} {tc} {td} {te} {tf}");
        }
    }
}

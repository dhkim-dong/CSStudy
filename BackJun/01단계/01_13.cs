using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._01단계
{
    internal class _01_13
    {
        static void Main13(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int r3 = b / 100;                        // b의 100의 자리 숫자
            int r2 = (b - r3*100) / 10;                  // b의 10의 자리 숫자
            int r1 = b - r3*100 - r2*10;                    // b의 1의 자리 숫자
            Console.WriteLine(a* r1);
            Console.WriteLine(a* r2);
            Console.WriteLine(a* r3);
            Console.WriteLine((a * r1)+(a * r2 * 10)+(a * r3 * 100));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._02단계
{
    internal class _02_02
    {
        static void Main2(string[] args)
        {
            int result = int.Parse(Console.ReadLine());

            if (90 <= result && result <= 100)
            {
                Console.WriteLine("A");
            }
            else if (80 <= result && result < 90)
            {
                Console.WriteLine("B");
            }
            else if (70 <= result && result < 80)
            {
                Console.WriteLine("C");
            }
            else if (60 <= result && result < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}

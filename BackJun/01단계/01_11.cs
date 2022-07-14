using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._01단계
{
    internal class _01_11
    {
        static void Main11(string[] args)
        {
            int sub = 2541 - 1998;

            int input = int.Parse(Console.ReadLine());
            int y = input;
            y -= sub;
            Console.WriteLine(y);
        }
    }
}

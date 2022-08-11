using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._13단계
{
    internal class _13_05
    {
        static void Main1(string[] args)
        {

            int R = int.Parse(Console.ReadLine());

            double circle = R * R * Math.PI;

            Console.WriteLine("{0:F6}",circle);

            int rec = (2 * R) * (2 * R) / 2;

            Console.WriteLine("{0:F6}",rec);
        }
    }
}

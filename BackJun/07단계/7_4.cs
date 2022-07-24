using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._07단계
{
    internal class _7_4
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int V = int.Parse(inputs[2]);

            int Dday = CheckMax(A, B, V);

            
            if(A==V)
            {
                Console.WriteLine(1);
            }
            else if (A * (Dday - 1) - B * (Dday - 2) >= V)
            {
                Console.WriteLine(Dday - A + 1);
            }   
            else
            {
                Console.WriteLine(Dday);
            }
           
        }

        static int CheckMax(int a, int b, int v)
        {
            double result = ((double)v - (double)b) / ((double)a - (double)b);

            return (int)Math.Ceiling(result);
        }
    }
}

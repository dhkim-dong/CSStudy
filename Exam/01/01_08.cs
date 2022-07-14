using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_08
    {
        static void Main8(string[] args)
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int x = i; x<4; x++)
                {
                    Console.Write(" ");
                }

                for (int y=0; y < 2*i+1; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            
        }
    }
}

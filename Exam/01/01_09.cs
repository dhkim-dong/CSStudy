using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_09
    {
        static void Main9(string[] args)
        {
            int count = 0;

            for (int i = 0; i <=9; i++)
            {
                if (i < 5)
                    count++;
                else
                    count--;

                for (int x = count; x < 5; x++)
                {
                    Console.Write(" ");
                }

                for (int y = 0; y < 2 * (count - 1) + 1; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

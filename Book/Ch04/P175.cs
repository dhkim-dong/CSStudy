using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P175
    {
        // ~176
        static void Main27(string[] args)
        {
            Console.WriteLine("코드 4-20");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 10; x > y; x--)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }
        }
    }
}

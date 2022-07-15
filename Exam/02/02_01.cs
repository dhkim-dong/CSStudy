using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{
    internal class _02_01
    {
        static void Main1(string[] args)
        {
            char[] str = { 'I', ' ', 'L', 'O', 'V', 'E', ' ', 'Y', 'O', 'U' };
            int row = 10;
            int col;

            for (int i = 1; i < row; i++)
            {
                for (int y = 0; y < i+1; y++)
                {
                    Console.Write(str[y]);
                }
                Console.Write('\n');
            }
        }
    }
}

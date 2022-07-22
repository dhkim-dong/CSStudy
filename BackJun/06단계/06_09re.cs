using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_09re
    {
        static void Main1(string[] args)
        {
            string input = Console.ReadLine();
            string[] croatia = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

            for (int i = 0; i < croatia.Length; i++)
            {
                input = input.Replace(croatia[i], "a");
            }
            Console.WriteLine(input.Length);
        }
    }
}

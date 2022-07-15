using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_06
    {
        static void Main6(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = input; i > 0; i--)
            {
                sb.Append(i.ToString() + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

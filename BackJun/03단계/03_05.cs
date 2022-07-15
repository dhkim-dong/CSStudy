using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_05
    {
        static void Main5(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= input; i++)
            {
                sb.Append(i.ToString() + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

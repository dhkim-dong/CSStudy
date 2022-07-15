using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_09
    {
        static void Main9(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                for (int x = 0; x < i+1; x++)
                {
                    sb.Append("*");                  
                }
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }
    }
}

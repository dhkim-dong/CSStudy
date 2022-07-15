using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_10
    {
        static void Main10(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                for (int x = N; x > i+1; x--)
                {
                    sb.Append(" ");
                    //Console.Write(" ");
                }

                for (int y = 0; y < i+1; y++)
                {
                    sb.Append("*");
                    //Console.Write("*");
                }
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }
    }
}

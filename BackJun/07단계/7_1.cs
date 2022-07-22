using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._07단계
{
    internal class _7_1
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            long a = long.Parse(inputs[0]);
            long b = long.Parse(inputs[1]);
            long c = long.Parse(inputs[2]);
            Console.WriteLine(SerachProfit(a, b, c));

            static long SerachProfit(long a, long b, long c)
            {
                if (b >= c)         // 코딩에서 중요한 것은 논리적인 사고력이다.. 라는 것을 깨달음
                {
                    return -1;
                }
                else 
                {
                    long n = a / (c - b);
                    return n + 1;
                }
            }
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._05단계
{
    internal class _05_03
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());


            int count = 0;
            int[] values = new int[N];

            //한수

            for (int i = 1; i < N; i++)
            {
                int s = i;
                int dis = 0;
                if(s == 1000)
                {
                    break;
                }
                else if(s >= 100 && s < 1000)
                {
                    dis = (s / 100) % - (s / 10) % 10;
                    if ((s / 10) % 10 - s % 10 == dis)
                        count++;
                }
                else 
                {
                    count++;
                }
            }
            sb.Append(count.ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}

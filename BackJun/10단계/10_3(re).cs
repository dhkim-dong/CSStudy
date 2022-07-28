using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._10단계
{
    internal class _10_3_re_
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] height = new int[N];
            int[] weight = new int[N];
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                height[i] = int.Parse(input.Split()[0]);
                weight[i] = int.Parse(input.Split()[1]);
            }

            for (int i = 0; i < N; i++)
            {
                count = 0;
                for (int j = 0; j < N; j++)
                {
                    if (height[i] < height[j] && weight[i] < weight[j])
                    {
                        count++;    
                    }
                }
                Console.WriteLine(count + 1);
            }
        }
    }
}

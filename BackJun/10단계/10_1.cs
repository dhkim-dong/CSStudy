using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._10단계
{
    internal class _10_1
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            string[] Num = Console.ReadLine().Split();
            List<int> blackJack = new List<int>();

            for (int i = 0; i < N; i++)
            {
                blackJack.Add(int.Parse(Num[i]));
            }

            blackJack.Sort();

            // 리스트를 정렬한다.
            // 같은 원소를 사용하면 안된다.
            int result = 0;
            List<int> value = new List<int>();

            for (int i = N-1; i >= 2; i--)
            {
                for (int j = N-2; j >= 1; j--)
                {
                    for (int c = N-3; c >= 0; c--)
                    {
                        if (i == j || i == c || j == c)
                        {
                            continue;
                        }

                        if(blackJack[i] + blackJack[j] + blackJack[c] <= M)
                        {
                            result = blackJack[i] + blackJack[j] + blackJack[c];
                            value.Add(result);
                        }
                    }
                }
            }
            Console.WriteLine(value.Max()); 
        }
    }
}

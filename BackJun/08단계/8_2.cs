using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._08단계
{
    internal class _8_2
    {
        static void Main1(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());


            List<int> Prime = new List<int>();

            int baseValue = 0;
            bool isPrime = true;

            int count = 0;

            for (int i = 0; i < N - M +1; i++)
            {
                baseValue = M + i;

                isPrime = true;
                if (baseValue == 1)        // 1은 소수가 아님!!
                {
                    continue;
                }
                for (int x = 2; x < baseValue - 1; x++)
                {
                    if (baseValue % x == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Prime.Add(M + i);
                    //Result[i] = M + i;     // i가 가장 작은 index value를 indexof로 찾기 , i가 아니면서~
                }
            }
            if(Prime.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                int tot = 0;

                foreach (int prime in Prime)
                {
                    tot += prime;
                }

                Console.WriteLine(tot);

                // 최솟값 구하기 ( 0이 아닌..) 방법은.. List로 구현해서 List.Add로 구하면된다
                int minPrime = Prime.Min();
                Console.WriteLine(minPrime);
            }        
        }
    }
}

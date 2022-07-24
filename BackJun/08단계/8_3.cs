using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._08단계  // 소인수 분해
{
    internal class _8_3 // 소수를 구해서 해당 소수를 모두 넣어 값을 구하는 방식 : 시간초과!
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> Prime = new List<int>();

            int baseValue = 0;
            bool isPrime = true;


            for (int i = 1; i <= N; i++)
            {
                baseValue = i;

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
                    Prime.Add(i);
                }
            }

            int tempNum = 0;

            if (N == 1)
            {

            }
            else
            {
                for (int i = 0; i < Prime.Count; i++)
                {
                    if(N % Prime[i] == 0)
                    {
                        tempNum = N / Prime[i];
                        Console.WriteLine(Prime[i]);

                        while (true)
                        {
                            if (tempNum % Prime[i] == 0)
                            {
                                tempNum /= Prime[i];
                                Console.WriteLine(Prime[i]);
                            }
                            else
                            {
                                break;
                            }
                        }                      
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._08단계
{
    internal class _8_1
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int baseValue = 0;
            bool isPrime = true;

            int count = 0;

            for (int i = 0; i < N; i++)
            {
                baseValue = Convert.ToInt32(inputs[i]); // (1) 첫번째 값

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
                    count++;
            }

            Console.WriteLine(count);
        }       
    }
}

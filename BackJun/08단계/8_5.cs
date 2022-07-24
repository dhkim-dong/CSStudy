using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._08단계
{
    internal class _8_5
    {
        static void Main1(string[] args)
        {
            while (true)
            {
                StringBuilder sb = new StringBuilder();
                int N = int.Parse(Console.ReadLine());
                if (N == 0)
                    break;

                // n보다 크고 2n보다 작거나 같은 소수의 개수를 출력하는 프로그램을 작성하세요.
                // 소수란 1과 자기 자신의 곱으로만 표현할 수 있는 숫자이다.. 몫 = 1 or 자기 자신..
                // 8 = 4(몫) * 2(나누는 수) or 2(나누는 수) * 4(몫) -> 몫 또는 나누는 수 둘중 하나는 반드시 8의 제곱근 보다 작다.
                // n을 자연수로 나눌 때 몫 또는 나누는 수는 반드시 n의 제곱근 보다 작기 때문에.. n의 제곱근 까지만 조사하면 된다.

                bool check = true;
                int min = N;
                int max = 2 * N;
                int count = 0;

                for (int i = min+1; i < max + 1; i++)
                {
                    check = true;
                    for (int k = 2; k<= Math.Sqrt(max); k++) // 에라토스테네스의 체 : 어떤 값이 소수라면 제곱근을 그보다 작은 소수로 나눌 수 없다.
                    {
                        if (i != k && i % k == 0)
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        count++;
                    }
                }
                sb.Append(count.ToString());
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }
    }
}

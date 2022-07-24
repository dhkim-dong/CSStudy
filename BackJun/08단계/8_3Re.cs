using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._08단계
{
    internal class _8_3Re
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i * i <= N; i++)           
            {
               if(N % i == 0)
                {
                    Console.WriteLine(i);
                    N /= i;    // N값을 나눈값으로 변경해준다.
                    i--;       // for문에서 1을 더하기 때문에 그것을 방지한다.
                }
            }

            // 왜 마지막 값은 출력되지 않을까?       i * i 조건 때문에.. 자기자신의 값보다는 작다.
            if(N > 1)
            {
                Console.WriteLine(N);
            }
        }
    }
}

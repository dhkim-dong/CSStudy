using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._08단계
{
    internal class _8_6
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            bool check = true;
            for (int i = 0; i < T; i++)
            {                              
                int n = int.Parse(Console.ReadLine());
                check = true;
                for (int x = 0; x < n; x++)
                {
                    int[] prime = new int[n];
                    for (int j = 2; j * j <= n; j++)
                    {
                        if (x != j && x % j == 0)
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        prime[x] = x;
                        int temp = n - prime[x];
                        if (CheckPrime(temp))
                        {
                            Console.WriteLine(prime[x] + " " + temp);
                        }
                    }                 
                }
                

                 
                
                // MySoultion; 
                // N보다 작은 소수를 찾는다.
                // 소수의 첫번째 값(2) n에서 뺀다.   둘 값이 모두 소수라면 골드바흐 파티션이다.
                // 골드바흐 파티션의 값이 여러개라면.. 두 소수의 차이가 가장 작은 것을 출력한다... (앞의 숫자가 큰 Case를 출력하시오..)
            }
        }

        static bool CheckPrime(int n)
        {
            bool check = true;
            for (int j = 2; j * j <= n; j++)
            {
                if (n % j == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._08단계
{
    internal class _8_6
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            bool check = true;
            List<int> primelist = new List<int>();

            for (int i = 0; i < T; i++)
            {                              
                
                int n = int.Parse(Console.ReadLine());
                for (int x = 0; x < n; x++)
                {
                    check = true;
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
                            if (prime[x] > temp)
                                continue;
                            primelist.Add(prime[x]);
                        }
                    }                    

                    //int maxPrime = primelist[primelist.Count - 1];

                    //Console.WriteLine(maxPrime + " " + (n - maxPrime));
                }
                sb.Append((primelist.Max() + " " + (n - primelist.Max()).ToString()));
                Console.WriteLine(sb.ToString());
                sb.Clear();
                primelist.Clear();

                // MySoultion; 
                // N보다 작은 소수를 찾는다.
                // 소수의 첫번째 값(2) n에서 뺀다.   둘 값이 모두 소수라면 골드바흐 파티션이다.
                // 골드바흐 파티션의 값이 여러개라면.. 두 소수의 차이가 가장 작은 것을 출력한다... (앞의 숫자가 큰 Case를 출력하시오..)
                // N값을 2로 나눈 후    앞의 값을 1씩 줄이고 뒤의 값을 1씩 증가시켜  (N/2 -1) +(N/2 +1) = N 을 이용
                // 각각의 A, B값이 소수이면 (bool true)일 때 그 값을 출력시켜라..
                // 가장 먼저 등장하는 값이 차이가 가장 작은 값이기 때문에 그대로 출력하면 된다.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 에레토스네테스의 체 : 소수를 빠르게 판별하는 알고리즘 
 * 내용 1:  특정 숫자의 제곱근까지 약수 여부를 검증하면 빠르게 구할 수 있다.. i * i..  시간 복잡도 1/2 제곱만큼 줄어든다
 * 내용 2 : 대량의 소수를 구하려면 특정 범위의 배열에서 소수의 곱을
 * 방법 : 2부터 시작해서 특정 수의 배수를 모두 지운다.( 자기 자신은 지우지 않음) 남아 있는 수를 모두 출력한다.
 */



namespace BackJun._08단계
{
    internal class _8_4 
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] inputs = Console.ReadLine().Split();
            int M = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);


            bool check = true;
            // 1. 배열을 초기화 한다.

            if (M == 1) M++;

            for (int i = M; i < N + 1; i++)
            {
                check = true;
                for (int k = 2; k*k < N +1; k++)
                {
                    if(i!=k && i%k == 0)
                    {
                        check = false;
                        break;
                    }           
                }
                if (check)
                {
                    sb.Append(i.ToString() + "\n");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

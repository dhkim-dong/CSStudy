using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._15단계
{
    internal class _15_01
    {
        static void Main(string[] args)
        {
            // 배수와 약수

            // 출력 제한을 위한 조건
            StringBuilder sb = new StringBuilder();

            // 두개의 수를 입력 받아라.

            while (true)
            {
                string[] inputs = Console.ReadLine().Split();
                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);

                if (x != 0 && y != 0) // 0 으로 나누는 경우와 0을 나누는 경우를 제외하고, 마지막에 0 0 을 입력하여 탈출하기 위함
                {
                    // 1번이 2번의 약수라면 factor
                    if (y % x == 0)
                    {
                        sb.Append("factor\n"); // String builder에 저장한 후 한줄 띄어쓰기! => 틀린 이유
                    }
                    // 1번이 2번의 배수라면 multiple
                    else if (x % y == 0)
                    {
                        sb.Append("multiple\n");
                    }
                    // 둘다 아니라면 neither
                    else
                    {
                        sb.Append("neither\n");
                    }                    
                }
                else
                    break;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

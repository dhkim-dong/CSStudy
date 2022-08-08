using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._13단계
{
    internal class _13_04
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());

            List<int> listA = new List<int>();
            List<int> listB = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                listA.Add(int.Parse(inputs[0]));
                listB.Add(int.Parse(inputs[1]));
            }

            // listA가 1,2인 그룹에서 가장 큰 값 x listA가 3,4인 그룹에서 가장 큰 값 y를 곱한 값에서.
            // 가장 큰수가 (1,4)(1,3)(2,4)(2,3) => 3번째 꼭지 / 4번째 꼭지 / 2번째 꼭지 / 1번째 꼭지가 빈다.

        }
    }
}

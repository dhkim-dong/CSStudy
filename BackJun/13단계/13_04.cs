using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._13단계
{
    internal class _13_04
    {
        static void Main1(string[] args)
        {
            int K = int.Parse(Console.ReadLine());

            List<int> listA = new List<int>();
            List<int> listB = new List<int>();
            Dictionary<int, int> inputDic = new Dictionary<int, int>();

            for (int i = 0; i < 6; i++)
            {
                string[] inputs = Console.ReadLine().Split();

                inputDic.Add(i, int.Parse(inputs[1]));

                if (int.Parse(inputs[0]) <= 2)
                    listA.Add(int.Parse(inputs[1]));

                if (int.Parse(inputs[0]) > 2)
                    listB.Add(int.Parse(inputs[1]));
            }

            int listAmax = listA.Max();
            int listBmax = listB.Max();

            int A = Array.IndexOf(inputDic.Values.ToArray(), listAmax);
            int B = Array.IndexOf(inputDic.Values.ToArray(), listBmax);

            int searchIndex = (A > B) ? A : B;

            // 큰 사각형의 넓이
            int bigRec = inputDic[A] * inputDic[B];

            // 작은 사각형의 넓이

            int s1 = searchIndex + 2;
            int s2 = searchIndex + 3;
            if (s1 > 5)
                s1 -= 6;
            if (s2 > 5)
                s2 -= 6;
                

            int smallRec = inputDic[s1] * inputDic[s2];

            int result = K * (bigRec - smallRec);
            Console.WriteLine(result);

            // 두번째로 찾은 잘리지 않은 변에서 2번 째와 3번 째 인덱스는 작은 사각형의 변의 길이이다. (사각형을 반시계 방향으로 탐색하기 때문)
            // (1,2) (3,4) 구별하여 가장 큰 값을 찾는다.
            // 전체에서 (1,2) (3,4)최대값의 인덱스를 찾는다.
            // 둘의 인덱스가 큰 값을 기준 값으로한다.
            // 기준 인덱스의 +2, +3의 인덱스의 값으로 작은 사각형의 넓이를 구한다.

        }
    }
}

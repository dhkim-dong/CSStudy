using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_10
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();



            string[] value = Console.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                int index = i;

                list.Add(int.Parse(value[i]));
            }

            // [i]행의 값보다 큰 다른 값이 몇개 있나요?

            // 정렬을 사용해서 index번호 -1을 출력하면 된다.인덱스번호가 0이라면?

            var output = list.Distinct().ToList();

            // 해시테이블의 키값과 같으면 해당 value를 출력할 것.
            Dictionary<int, int> sort = new Dictionary<int, int>();

            for (int i = 0; i < output.Count; i++)
            {
                sort.Add(output[i], i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == output.GetHashCode())
                {
                    Console.WriteLine(output[list[i]]);
                }
            }

            /* 시간 초과 : 전체를 다 비교하면서 Count를 세기 때문에
            for (int i = 0; i < list.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (i == j)
                        continue;

                    if (list[i] > list[j])
                        count++;
                }
                result.Add(count);
            }
            foreach(int count in result)
            {
                sb.Append(count + " ");
            }

            */

        }
    }
}

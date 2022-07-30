using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_04
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int value = int.Parse(Console.ReadLine());
                list.Add(value);
            }

            sb.Append((int)Math.Round(list.Average())+ "\n");



            // 리스트 중앙값 구하는법?

            list.Sort();
            sb.Append(list[list.Count / 2] + "\n");


            // 리스트 최빈값 구하는법?
            // 데이터(인덱스)를
            // 각각의 인덱스와 같은 값을 저장하는 리스트를 생성해야 한다.
            int[] index = new int[list.Count];
            int[] result = new int[list.Count];
            int max = 0;
            int mode = 0;

            for (int i = 0; i < list.Count; i++)
            {
                index[i] = list[i];
            }

            for (int i = 0; i < index.Length; i++)
            {
                max = index[i];
                mode = 0;
                for (int j = 0; j < index.Length; j++)
                {
                    if (j != i && index[j] == index[i])
                    {
                        mode++;
                    }
                }
                result[i] = mode;
            }

            sb.Append(list[result.Max()] + "\n");

            sb.Append(list.Max() - list.Min());

            Console.WriteLine(sb);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_04
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int value = int.Parse(Console.ReadLine());
                list.Add(value);
            }

            int r1 = (int)Math.Round(list.Average());

            int r4 = list.Max() - list.Min();


            // 리스트 중앙값 구하는법?

            list.Sort();
            int r2 = list[list.Count / 2];


            // 리스트 최빈값 구하는법?
            int[] index = new int[list.Count + 1];
            int max = index.Min();
            int mode = 0;

            for (int i = 0; i < list.Count; i++)
            {
                index[i] = list[i];
            }

            for (int i = 0; i < index.Length; i++)
            {
                if (index[i] > max)
                {
                    max = index[i];
                    mode = i;
                }
            }

            int r3 = mode;

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
        }
    }
}

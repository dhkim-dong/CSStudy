using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_11
    {
        static void Main11(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);

            int[] value = new int[a];
            StringBuilder sb = new StringBuilder();

            // a개를 입력받고 b보다 작은 값을 출력하라


            // 한 줄에 a개의 입력을 받는 방법?

            string[] values = Console.ReadLine().Split();
            for (int i = 0; i < a; i++)
            {
                value[i] = int.Parse(values[i]);

                if (value[i] < b)
                {
                    sb.Append(value[i].ToString() + " ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

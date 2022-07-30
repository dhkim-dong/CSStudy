using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_02_re_
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N]; 

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            StringBuilder sb = new StringBuilder();

            sb.Append(String.Join("\n", arr));

            Console.WriteLine(sb);
        }
    }
}

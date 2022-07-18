using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_01
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int[] values = new int[T];

            string[] inputs = Console.ReadLine().Split();

            for (int i = 0; i < T; i++)
            {
                values[i] = int.Parse(inputs[i]);
            }
            sb.Append(values.Min().ToString() + " ");
            sb.Append(values.Max().ToString());

            Console.WriteLine(sb.ToString());
        }
    }
}

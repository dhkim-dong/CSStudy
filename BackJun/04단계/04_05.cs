using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_05
    {
        static void Main5(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int[] value = new int[N];

            for (int i = 0; i < N; i++)
            {
                value[i] = int.Parse(inputs[i]);
            }

            int maxScore = value.Max();

            double[] newValue = new double[N];

            for (int i = 0; i < N; i++)
            {
                newValue[i] = ((double)value[i] / (double)maxScore) * 100;
            }
            double tot = 0;

            

            foreach(double score in newValue)
            {
                tot += score;
            }

            double result = tot / N;

            sb.Append(result.ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_07re
    {
        static void Main8(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            int[] temp = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split();

                double average = 0;
                double total = 0;              
                int totNum = int.Parse(values[0]);
                int count = 0;
                double results = 0;
                for (int x = 1; x < values.Length; x++)
                {
                    total += double.Parse(values[x]);
                }
                average = total / totNum;

                for (int y = 1; y < values.Length; y++)
                {
                    if (double.Parse(values[y]) > average)
                        count++;
                }

                results = (double)count / (double)totNum * 100;

                sb.Append(String.Format("{0:0.000}" + "%" + "\n", results));               
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

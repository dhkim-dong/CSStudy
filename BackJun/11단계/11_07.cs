using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_07
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            List<(int, int)> list = new List<(int, int)>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                int x = int.Parse(input[0].ToString());
                int y = int.Parse(input[1].ToString());
                list.Add((x, y));
            }

            var output = list.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToList();

            for (int i = 0; i < N; i++)
            {
                sb.Append(output[i].Item1 + " " + output[i].Item2 + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}

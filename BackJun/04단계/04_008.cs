using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_008
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] group = new int[N];

            string[] input = Console.ReadLine().Split();

            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < group.Length; i++)
            {
                group[i] = int.Parse(input[i]);
            }

            int count = 0;

            foreach(int i in group)
            {
                if (target == i)
                    count++;
            }

            Console.WriteLine();
        }
    }
}

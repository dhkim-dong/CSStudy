using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_09
    {
        static void Main1(string[] args)
        {
            List<int> result = new List<int>();

            for (int i = 1; i <= 30 ; i++)
            {
                result.Add(i);
            }

            for (int i = 0; i < 28; i++)
            {
                int n = int.Parse(Console.ReadLine());
                result.Remove(n);
            }

            result.Sort();
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}

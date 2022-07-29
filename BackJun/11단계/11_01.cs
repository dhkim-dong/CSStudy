using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_01
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int values = int.Parse(Console.ReadLine());
                list.Add(values);
            }

            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}

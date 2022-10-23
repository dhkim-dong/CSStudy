using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._13단계
{
    internal class _13_03
    {
        static void Main2(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                int r1 = int.Parse(input[0]);
                int r2 = int.Parse(input[1]);
                int r3 = int.Parse(input[2]);

                if (r1 == 0 && r2 == 0 && r3 == 0)
                    break;

                List<int> list = new List<int>();

                list.Add(r1);
                list.Add(r2);
                list.Add(r3);

                list.Sort();

                r1 = list[0];
                r2 = list[1];
                r3 = list[2];

                if(r3 * r3 == r1* r1 + r2* r2)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
        }
    }
}

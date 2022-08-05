using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._12단계
{
    internal class _12_5
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            List<string> strN = new List<string>();
            List<string> strM = new List<string>();


            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                strN.Add(s);
            }

            for (int i = 0; i < M; i++)
            {
                string s = Console.ReadLine();
                strM.Add(s);
            }

            var result = strN.Intersect(strM).ToList();
            result.Sort();
            Console.WriteLine(result.Count);
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}

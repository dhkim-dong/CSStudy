using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._12단계
{
    internal class _12_6
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            List<int> listA = new List<int>();
            List<int> listB = new List<int>();

            string[] stringA = Console.ReadLine().Split(); 

            for (int i = 0; i < A; i++)
            {
                listA.Add(int.Parse(stringA[i]));
            }

            string[] stringB = Console.ReadLine().Split();

            for (int i = 0; i < B; i++)
            {
                listB.Add(int.Parse(stringB[i]));
            }

            var interList = listA.Intersect(listB).ToList();
            var unionList = listA.Union(listB).ToList();

            Console.WriteLine(unionList.Count - interList.Count);
        }
    }
}

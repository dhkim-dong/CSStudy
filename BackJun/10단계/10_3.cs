using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._10단계
{
    internal class _10_3
    {
        static List<int> Hgroup = new List<int>();
        static List<int> Wgroup = new List<int>();

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Compare(N, i);
            }
        }

        // 데이터 입력
        static void InputData()
        {

        }


        static int Compare(int n, int n1) // 비교 주체
        {         
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split();

                int weight = int.Parse(inputs[0]);
                int height = int.Parse(inputs[1]);

                Hgroup.Add(height);
                Wgroup.Add(weight);
            }

            int level = n;

            for (int i = 0; i < n-1; i++)
            {
                if (n1 == i)
                    continue;

                if (Hgroup[n1] > Hgroup[i])
                {
                    level--;
                }
                else
                    continue;
            }

            return level;
        }
    }
}

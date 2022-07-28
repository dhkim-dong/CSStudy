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
        static List<int> result = new List<int>();

        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split();

                int weight = int.Parse(inputs[0]);
                int height = int.Parse(inputs[1]);

                Hgroup.Add(height);
                Wgroup.Add(weight);
            }

            for (int i = 0; i < N; i++)
            {
                Compare(N, i);
            }

            // 순위가 같을 때 로직 처리
            if(Sort1(result) > 1)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != 1 && result[i] != result.Count)
                    {
                        result[i] += Sort1(result);
                    }
                }
            }

            if (Sort2(result) > 1)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != 1 && result[i] != 2 && result[i] != result.Count)
                    {
                        result[i] += Sort2(result);
                    }
                }
            }

            if (Sort3(result) > 1)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != 1 && result[i] !=2 && result[i] !=3 && result[i] != result.Count)
                    {
                        result[i] += Sort3(result);
                    }
                }
            }
        }


        static void Compare(int n, int n1) // 비교 주체
        {         
            int level = n;

            for (int i = 0; i < n; i++)
            {
                if (n1 == i)
                    continue;

                if (Hgroup[n1] > Hgroup[i] || Wgroup[n1] > Wgroup[i]) // 1등은 문제가 없다.
                {
                    level--;
                }
                else
                {
                    continue;
                }
            }
            result.Add(level);      
        }

        

        // 한번에 처리할 메서드를 만들어야 한다.

        static int Sort1(List<int> result)
        {
            var output = from item in result
                         where item == 1
                         select item;

            return output.Count();
        }

        static int Sort2(List<int> result)
        {
            var output = from item in result
                         where item == 2
                         select item;

            return output.Count();
        }

        static int Sort3(List<int> result)
        {
            var output = from item in result
                         where item == 3
                         select item;

            return output.Count();
        }

        static int Sort4(List<int> result)
        {
            var output = from item in result
                         where item == 4
                         select item;

            return output.Count();
        }
    }
}

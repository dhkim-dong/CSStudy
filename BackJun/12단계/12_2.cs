using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1) 차집합을 풀었더니 오답이 발생 -> 중복되는 값을 모두 없애서 Count값이 다르게 나왔기 때문 
 * 2) index를 활용해서 해당하는 값을 소유하고 있다면 count를 증가시키고 출력하자 
 */



namespace BackJun._12단계
{
    internal class _12_2
    {
        static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int count = 0;

            List<string> first = new List<string>();
            List<string> second = new List<string>();

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < N; i++)
            {
                string value = Console.ReadLine();
                first.Add(value);
            }

            for (int i = 0; i < N; i++)
            {
                set.Add(first[i]);
            }

            for (int i = 0; i < M; i++)
            {
                string value = Console.ReadLine();
                second.Add(value);
            }

            for (int i = 0; i < M; i++)
            {
                if (set.Contains(second[i]))
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}

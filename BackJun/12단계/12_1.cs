using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 단원이 집합이기 때문에
// 집합을 이용해서 문제를 풀어보자.. List두개를 합친다

/*
 *  
 * 데이터의 범위는 크지만 Value ~10억 // 데이터의 크기는 작을때(50만) 
 * 카운트 솔팅 (Count Sorting Array)을 사용해보자
 * 카운트 솔팅 : 정수를 값으로 갖는 배열에서 데이터의 등장한 횟수를 저장하여 이 데이터를 정렬하는 알고리즘
 * 
 */


namespace BackJun._12단계
{
    internal class _12_01
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());

            List<int> firstList = new List<int>();

            string[] value = Console.ReadLine().Split();

            for (int i = 0; i < N; i++)
            {
                firstList.Add(int.Parse(value[i].ToString()));
            }
            firstList.Sort();

            int M = int.Parse(Console.ReadLine());

            List<int> compareList = new List<int>();

            string[] comp = Console.ReadLine().Split();

            for (int i = 0; i < M; i++)
            {
                compareList.Add(int.Parse(comp[i].ToString()));
            }


            for (int i = 0; i < M; i++)
            {
                if (binary(firstList, 0, firstList.Count - 1, compareList[i]))
                {
                    sb.Append("1" + " ");
                }
                else
                {
                    sb.Append("0" + " ");
                }
            }
            Console.WriteLine(sb);
        }

        public static bool binary(List<int> list, int start, int end, int target)
        {
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (list[mid] == target)
                    return true;
                else if (list[mid] > target)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return false;
        }
    }
}
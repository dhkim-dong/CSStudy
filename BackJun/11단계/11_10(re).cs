using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 백준 실버2 단계의 수준 : 해답에 이루는 알고리즘을 구현한 후 해당 알고리즘의 시간 복잡도를 간결화 할 수 있는가? 보통 n 이하의 시간 복잡도 
 */




namespace BackJun._11단계
{
    internal class _11_10_re_
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            string[] arr = Console.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                list.Add(int.Parse(arr[i].ToString()));
            }

            var result = list.Distinct().ToList();

            result.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(low_Value(list[i],result,result.Count) + " ");
            }
            Console.WriteLine(sb);
        }

        
        // ?? 

        static int low_Value(int target, List<int> data, int length)
        {
            int left = 0;
            int right = length;

            while(left < right)
            {
                int mid = (left + right) / 2;
                if (data[mid] >= target)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return right;
        }
    }
}

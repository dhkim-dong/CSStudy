using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._09단계
{
    internal class _9_5
    {
        static int count = 0;
        static StringBuilder sb = new StringBuilder();
        static void Main1(string[] args)
        {            
            int K = int.Parse(Console.ReadLine());

            hanoi(K,1,2,3);
            Console.WriteLine(count);
            Console.WriteLine(sb.ToString());
            // 1 ~ K번째 원반을 (A,B,C) -> A에서 C로 이동시키고 싶다.
            // K원반을 C로 이동시키고 싶다.
            // (1) A에서 경유지인 B로 K-1개를 이동시킨다.
            // (2) A에서 C로 1개 이동시킨다.
            // (3) B에 있는 k-1개를 C로 이동 시키고 싶다.. (반복)


        }
        // 1 3 : 1에서 3으로 이동하라..
        static void hanoi(int n , int start, int to , int goal)
        {
            if(n == 1)
            {
                sb.Append($"{start} {goal}\n");
                count++;
            }
            else
            {
                hanoi(n - 1, start, goal, to);

                sb.Append($"{start} {goal}\n");
                count++;

                hanoi(n - 1, to, start, goal);
            }
        }
    }
}

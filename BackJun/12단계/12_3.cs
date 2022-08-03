using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._12단계
{
    internal class _12_3
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            StringBuilder sb = new StringBuilder();

            // 번호가 1 ~ N번까지 한줄에 하나// 첫글자는 대문자 // 일부는 마지막이 대문자  
            // 이름 최대 20 ~  최소 2
            // 문제? 숫자 또는 문자로 들어오면 해당하는 값을 출력해야 한다 -> Dictionary사용해라

            Dictionary<string, int> pocketMon = new Dictionary<string, int>();
            Dictionary<int, string> pocketNum = new Dictionary<int, string>();

            for (int i = 0; i < N; i++)
            {
                string p = Console.ReadLine();
                pocketMon.Add(p, i);
                pocketNum.Add(i+1, p);
            }


            for (int i = 0; i < M; i++)
            {
                // 숫자로 들어오는지 문자로 들어오는지 알수가 없다 -> string을 찾을 수 있으면 -> 없다면 else 처리
                string q = Console.ReadLine();

                if (q[0] < 'A')
                {
                    int index = int.Parse(q);
                    sb.Append(pocketNum[index] + "\n");
                }   
                else
                {
                    sb.Append(pocketMon[q]+1 + "\n");
                }             
            }
            Console.WriteLine(sb);
        }
    }
}

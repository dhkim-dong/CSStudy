using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_08
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            // N 1 ~20000;
            int N = int.Parse(Console.ReadLine());

            // input은 50을 넘지 않는다. => 배열로 선언할 시 length 51로 하면 된다.
            // (input의 length, input의 키값)
            List<(int,string)> list = new List<(int,string)>();

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();

                list.Add((input.Length, input));
            }

            // 정렬을 한다. 조건(1) : input의 Length은 작은 값부터
            // 조건(2) : 알파벳의 오름차순 순서로

            var output = list.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();

            // 리스트 중복 제거
            output =  output.Distinct().ToList();


            for (int i = 0; i < output.Count; i++)
            {
               sb.Append(output[i].Item2 + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}

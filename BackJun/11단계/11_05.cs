using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    // 각자리수를 내림차순으로 정렬하는 알고리즘

    internal class _11_05
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string N = Console.ReadLine();
            List<int> list = new List<int>();
            // N은 엄청 큰 수이다. 엄청 큰 수의 각 자리수를 시간 절약하여 나타내는 방법이 무엇이 있을까?
            // (1) 각 자리수를 리스트화 한 다음에 정렬을 사용한뒤 출력한다.
            // (1) 배열
            // 첫번 째 자리수가 뒤에 자리수보다 작으면 두 수를 바꾼다.

            for (int i = 0; i < N.Length; i++)
            {
                list.Add(int.Parse(N[i].ToString()));
            }

            var output = from item in list
                         orderby item descending
                         select item;

            foreach(int i in output)
            {
                sb.Append(i.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._05단계
{
    internal class _05_02
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int dn = 0;
            int[] dArray = new int[10000];
            for (int i = 0; i < dArray.Length; i++)
            {
                dArray[i] = i;
            }


            int[] compare = new int[10000];

            for (int i = 0; i < compare.Length; i++)
            {
                compare[i] = i;
            }


            // dN의 자리수는 1만보다 작거나 같다 = 즉 최대 5개의 자리수 까지 정의해야한다.
            // dn문자열이라 생각한다면 += (dn/10) + (dn[dn.Length])
            // dn = dn/10000 + dn/1000 + dn/100 + dn/10 + dn[dn.Length]
            // 생성자 구하는 식

            for (int i = 1; i < dArray.Length; i++)
            {
                dn = compare[i];
                //if (dn < 1)
                //    continue;

                if (dn == 10000)
                {
                    dn = 10001;
                }
                else if (dn >= 1000 && dn < 10000)
                {
                    dn += dn / 1000 + (dn/100)%10 + (dn/10)%10 + dn%10;
                }
                else if (dn >= 100 && dn < 1000)
                {
                    dn += dn / 100 + (dn/10)%10 + dn%10;
                }
                else if (dn >= 10 && dn < 100)
                {
                    dn +=  dn / 10 + dn%10;
                }
                else
                {
                    dn += dn;
                }
                dArray[i] = dn;
            }
            IEnumerable<int> differenceQuery = compare.Except(dArray);

            foreach (int value in differenceQuery)
                sb.Append(value.ToString()+"\n");

            Console.WriteLine(sb.ToString());

            // 두 배열의 비교

            // 셀프 넘버란? 생성자가 없는 숫자.
            // (1) 셀프 넘버를 구한다.
            // (2) 셀프 넘버의 List를 만든다.
            // (3) 1~10000을 원소를 가지는 배열  or 리스트를 만들고
            // (4) 해당 리스트에서 셀프 넘버의 List가 갖는 원소를 제거한다?
            // (5) 1~10000의 리스트의 모든 원소를 foreach로 출력한다.


            /* (1) 1의 자리수
               (2) 10의 자리수
               (3) 100의 자리수
               (4) 1000의 자리수
               (5) 10000 일 때
            */
        }
    }
}

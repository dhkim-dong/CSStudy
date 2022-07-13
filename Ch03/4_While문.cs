using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
   /*
    * 날짜 : 2022/07/13
    * 이름 : 김동훈
    * 내용 : 반복문 While 실습하기 교재 p162
    *
    */

    internal class _4_반복문
    {
        static void Main4(string[] args)
        {
            // while 
            int sum = 0;
            int k = 1;

            while (k <= 10)
            {
                sum += k;
                k++;
            }
            Console.WriteLine("1부터 10까지 합 : " + sum);

            // do ~while : while의 내용을 위로 올리고 do를 추가시킨 형태 : do를 한번 실행하고 조건을 확인하라.
            int total = 0;
            int i = 1;
            do
            {
                if(i % 2 == 0)
                {
                    total += i;
                }
                i++;
            }
            while (i<=10);

            Console.WriteLine("1부터 10까지 짝수합 : " + total);
            // break

            int num = 1;
            while (true)
            {
                if (num % 5 ==0 && num %7 ==0)
                {
                    break; // 가장 가가운 반복문 종료
                }
                num++;
            }
            Console.WriteLine("5와 7의 최소공배수 :" + num);
            // continue

            int tot = 0;
            int n = 0;
            while (n <= 10)
            {
                n++;
                if (n%2 ==1)
                {
                    continue; // 가장 가까운 반복문으로 이동하라.
                }
                tot += n;
            }
            Console.WriteLine("10이하의 짝수 합 : " + tot);
        }
    }
}

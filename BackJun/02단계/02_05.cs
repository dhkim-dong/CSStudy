using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._02단계
{
    internal class _02_05
    {
        static void Main5(string[] args)
        {
            // 현재 설정한 시간보다 45분 일찍 알람 설정하기
            // 첫째 줄에 시간과 분을 입력하시오.
            string[] inputs = Console.ReadLine().Split();
            int h = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);


            if (m < 45)
            {
                m = m + 60 - 45;
                if (h == 0)
                {
                    h = 23;
                }
                else
                {
                    h = h - 1;
                }
            }
            else
            {
                m -= 45;
            }

            Console.WriteLine($"{h} {m}");
        }
    }
}

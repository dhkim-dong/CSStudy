using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._02단계
{
    internal class _02_06
    {
        static void Main6(string[] args)
        {
            // 현재 시각을 시간과 분으로 표현하시오 한줄로
            string[] inputs = Console.ReadLine().Split();
            int h = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int cook = int.Parse(Console.ReadLine());

            // 끝나는 시간과 분을 출력하세요.
            // (1) cook 시간을 몫과 나머지로 시간과 분을 표현하세요.

            int cookh = cook / 60;
            int cookm = cook % 60;

            int A = h + cookh;
            int B = m + cookm;
            if (B > 59)
            {
                B -= 60;
                A += 1;
            }
            if (A > 23)
            {
                A -= 24;
            }
            Console.WriteLine($"{A} {B}");
        }
    }
}

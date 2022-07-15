using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._02단계
{
    internal class _02_03
    {
        static void Main3(string[] args)
        {
            // 윤년이면 1 아니면 0을 출력
            // 윤년은 4의배수이면서 && 100의 배수가 아닐 때 || 400의 배수 일때
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}

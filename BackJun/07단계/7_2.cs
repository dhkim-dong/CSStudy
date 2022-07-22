using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._07단계
{
    internal class _7_2
    {
        static void Main1(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            Console.WriteLine(SearchValue(N));
            
        }

        static long SearchValue(long a)
        {
            if (a == 1)
                return 1;

            for (long i = 1; true; i++)
            {
                if(a <= 3 * i*(i + 1) + 1)                   // 단 하나의 예외라도 발생하면 오류가 뜬다!
                {
                    return i + 1;
                }

            }
        }
    }
}

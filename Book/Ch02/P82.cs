using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P82
    {
        static void Main20(string[] args)
        {
            Console.WriteLine("코드 2-25 오버플로우");
            Console.WriteLine("");
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a+b);

            Console.WriteLine("코드 2-26 자료형 변환을 사용한 해결 방법 3가지");
            Console.WriteLine("");
            int c = 2000000000;
            int d = 2000000000;
            Console.WriteLine(c+d);

            Console.WriteLine("");
            Console.WriteLine("uint와 ulong 자료형");
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);

        }
    }
}

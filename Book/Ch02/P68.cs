using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P68
    {
        static void Main9(string[] args)
        {
            Console.WriteLine("코드 2-10 실수와 사칙 연산자");
            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * .0);
            Console.WriteLine(1.0 / 2.0);

            Console.WriteLine("코드 2-11 실수와 나머지 연산자");
            Console.WriteLine(5.0 % 2.2); // 5.0 %2.2의 몫 2 -> 5.0- ( 2.2 x2) 0.6 출력  이해하기 힘든 결과가 나온다
        }
    }
}

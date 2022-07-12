using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P66
    {
        static void Main7(string[] args)
        {
            Console.WriteLine("코드 2-6 정수와 연산자");
            Console.WriteLine(1 + 2);
            Console.WriteLine(1 - 2);
            Console.WriteLine(1 * 2);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 % 2);

            Console.WriteLine("코드 2-7 음수와 나머지 연산자"); // 왼쪽 피연산자의 부호를 따라간다.
            Console.WriteLine(4%3);
            Console.WriteLine(-4%3);
            Console.WriteLine(4%-3);
            Console.WriteLine(-4%-3);
        }
    }
}

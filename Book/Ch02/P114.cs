using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P114
    {
        static void Main48(string[] args)
        {
            Console.WriteLine("코드 2-66");
            double num = 52.27219231;
            Console.WriteLine(num.ToString("0.0")); // ToString( ) 의 매개 변수로 Format을 할 수 있다. 소수점의 최대 자리수를 표기할 수 잇음.
            Console.WriteLine(num.ToString("0.00"));
            Console.WriteLine(num.ToString("0.000"));
            Console.WriteLine(num.ToString("0.0000"));
            Console.WriteLine(num.ToString("0.00000"));

            Console.WriteLine("코드 2-67");
            Console.WriteLine(52+273);
            Console.WriteLine("52"+273);        // 숫자와 문자열 사이의 연산자는 문자열 연결 연산자로 확정된다.
            Console.WriteLine(52+"273");
            Console.WriteLine("52"+"273");
        }
    }
}

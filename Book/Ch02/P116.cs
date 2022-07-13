using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P116
    {
        static void Main50(string[] args)
        {
            Console.WriteLine("코드 2-69");
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("false"));
            Console.WriteLine(bool.Parse("False"));

            Console.WriteLine("코드 2-70");

            int output = int.MinValue;
            Console.WriteLine(-output); // -에 -부호를 넣어도 -값 그대로 출력된다.
            Console.WriteLine(-(-2121211512)); // 코드 오류는 발생한다.
        }
    }
}

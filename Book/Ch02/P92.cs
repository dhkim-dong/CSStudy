using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P92
    {
        static void Main29(string[] args)
        {
            Console.WriteLine("코드2-39 문자열과 관련된 복합 대입 연산자");
            string output = "hello";
            output += " world!";
            output += "!";

            Console.WriteLine(output);

            Console.WriteLine("코드 2-40 문자열과 관련된 복합 대입 연산자 예제 풀어쓰기");

            string oput = "hello ";
            oput = oput + "World";
            oput = oput + "!";
            Console.WriteLine(oput);
        }
    }
}

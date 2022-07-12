using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P85
    {
        static void Main23(string[] args)
        {
            Console.WriteLine("코드 2-13 문자 변수 생성");
            Console.WriteLine("");
            char a = 'a';
            Console.WriteLine(a);

            Console.WriteLine("코드 2-32 sizeof 연산자");
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long)); // 자료형의 크기를 알려주는 값 형
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));
        }
    }
}

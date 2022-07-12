using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P81
    {
        static void Main19(string[] args)
        {
            Console.WriteLine("코드 2-24 오버플로우");
            Console.WriteLine("");
            int a = 2147483640;
            int b = 52273;

            Console.WriteLine(a+b);   // 오버플로우가 발생하면 자료형의 시작부터 다시 센다. int형은 -부호를 포함하기 때문에..


            Console.WriteLine("코드 2-");
        }
    }
}

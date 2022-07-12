using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P95
    {
        static void Main32(string[] args)
        {
            Console.WriteLine("코드 2-43 후위 증감 증산자");

            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number); number += 1; // number++ 와 같은 의미
            Console.WriteLine(number); number -= 1; // number-- 와 같은 의미
            Console.WriteLine(number);
        }
    }
}

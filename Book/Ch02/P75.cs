using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P75
    {
        static void Main16(string[] args)
        {
            Console.WriteLine("코드 2-21 논리 부정 연산자");
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));
        }
    }
}

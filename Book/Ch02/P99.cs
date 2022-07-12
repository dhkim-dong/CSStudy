using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P99
    {
        static void Main35(string[] args)
        {
            Console.WriteLine("코드 2-47 직접적인 GetType() 메서드 활용");

            Console.WriteLine((273).GetType());
            Console.WriteLine((524525245253L).GetType());
            Console.WriteLine((52.273f).GetType());
            Console.WriteLine((52.2222222).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("ㄴㅇㄻㄻ").GetType());
        }
    }
}

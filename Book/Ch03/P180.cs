using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P180
    {
        static void Main31(string[] args)
        {
            Console.WriteLine("코드 4-25");
            for (int i = 0; i < 10; i++)
            {
                if(i %2 != 0) // 홀수면
                    Console.WriteLine(i);
            }
        }
    }
}

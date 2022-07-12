using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P91
    {
        static void Main28(string[] args)
        {
            Console.WriteLine("코드 2-37 숫자와 관련된 복합 대입 연산자");

            int output = 0;
            output += 52;
            output += 273;
            output += 103;
            Console.WriteLine(output);

            Console.WriteLine("코드 2-38 숫자와 관련된 복합 대입 연산자 다른 방식");

            int oput = 0;
            oput = oput + 52;
            oput = oput + 273;
            oput = oput + 103;

            Console.WriteLine(oput);
        }
    }
}

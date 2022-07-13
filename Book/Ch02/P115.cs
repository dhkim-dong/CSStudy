using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P115
    {
        static void Main49(string[] args)
        {
            Console.WriteLine("코드 2-68");
            int num = 52273;
            string outputA = num + ""; // 다른 자료형과 문자열을 더하면 문자열이 된다.
            Console.WriteLine(outputA);

            char character = 'a';
            string outputB = character + "";
            Console.WriteLine(outputB);
        }
    }
}

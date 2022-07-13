using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P108
    {
        static void Main43(string[] args)
        {
            Console.WriteLine("코드 2-59");
            long longNum = 52273;
            int intNum = (int)longNum;
            Console.WriteLine(intNum);

            Console.WriteLine("코드 2-60");

            long longN = 32316165165165L + 1465165165156165165L;
            int longToInt = (int)longN;
            Console.WriteLine(longToInt);
        }
    }
}

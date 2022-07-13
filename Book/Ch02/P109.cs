using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P109
    {
        static void Main44(string[] args)
        {
            Console.WriteLine("코드 2-61");
            int intNum = 2147483647;

            long intToLong = intNum;
            Console.WriteLine(intToLong);

            double intToDouble = intNum;
            Console.WriteLine(intToDouble);
        }
    }
}

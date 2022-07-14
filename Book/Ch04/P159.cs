using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P159
    {
        static void Main15(string[] args)
        {
            Console.WriteLine("코드 4-4");

            int[] intArray = { 52, 273, 32, 65, 103 };

            intArray[0] = 0;

            Console.WriteLine(intArray[0]);  // 0출력
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);

            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);

            Console.WriteLine("코드 4-5");

            int[] intArray2 = { 52, 273, 32, 65, 103 };
            Console.WriteLine(intArray2.Length);
        }
    }
}

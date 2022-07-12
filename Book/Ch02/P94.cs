using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P94
    {
        static void Main31(string[] args)
        {
            Console.WriteLine("코드 2-41(1) 증감 연산자의 후위 형태");
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number++); // 출력하고 더한다? 10을 출력하고 1을 더함 -> 11이됨
            Console.WriteLine(number--); // 출력하고 뺀다? 11을 출력하고 1을 뺌 -> 10이됨
            Console.WriteLine(number);

            Console.WriteLine("코드 2-42(2) 증감 연산자의 전위 형태");
            int num = 10;
            Console.WriteLine(num);
            Console.WriteLine(++num); // 더하고 출력한다 10+1 = 11
            Console.WriteLine(--num); // 빼고 출력한다 11-1 = 10
            Console.WriteLine(num);
        }
    }
}

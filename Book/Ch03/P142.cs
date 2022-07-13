using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P142
    {
        static void Main9(string[] args)
        {
            Console.WriteLine("코드 3-13");
            Console.Write("숫자를 입력해주세요 : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? true : false);

            Console.WriteLine(number % 2 != 0 ? "짝수" : "홀수");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P143
    {
        static void Main10(string[] args)
        {
            Console.WriteLine("코드 3-14");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.WriteLine(number>0 ? "자연수입니다." : "자연수가 아닙니다.");
        }
    }
}

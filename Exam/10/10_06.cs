using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._10
{
    internal class _10_06
    {
        static void Main1(string[] args)
        {
            var p1 = ("김유신", "010-1234-0001", 25);
            var p2 = ("김춘추", "010-1234-0002", 23);
            var p3 = (name: "장보고", hp: "010-1234-1003", 33);
            var p4 = (name: "강감찬", hp: "010-1234-0004", 41);
            var (name, hp, age) = ("이순신","010-1234-1005",52);

            Console.WriteLine($"{p1.Item1}, {p1.Item2}, {p1.Item3}");
            Console.WriteLine($"{p2.Item1}, {p2.Item2}, {p2.Item3}");
            Console.WriteLine($"{p3.Item1}, {p3.Item2}, {p3.Item3}");
            Console.WriteLine($"{p4.Item1}, {p4.Item2}, {p4.Item3}");
            Console.WriteLine($"{name}, {hp}, {age}");
        }
    }
}

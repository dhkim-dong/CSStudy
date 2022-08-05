using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._10
{
    internal class _10_08
    {
        class Member
        {
            public string Name { get; init; }
            public string Hp { get; init; }
            public int Age { get; init; }

            public override string ToString()
            {
                return $"{Name}, {Hp}, {Age}";
            }
        }

        static void Main1(string[] args)
        {
            Member m1 = new Member { Name = "김유신", Hp = "010-1234-0001", Age = 25 };
            Member m2 = new Member { Name = "김춘추", Hp = "010-1234-0002", Age = 23 };
            Member m3 = new Member { Name = "장보고", Hp = "010-1234-0003", Age = 37 };

            var m4 = new { Name = "강감찬", HP = "010-1234-1004", Age = 41 };
            var m5 = new { Name = "이순신", HP = "010-1234-1005", Age = 52 };

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);
        }
    }
}

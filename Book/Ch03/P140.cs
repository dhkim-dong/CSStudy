using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P140
    {
        static void Main8(string[] args)
        {
            Console.Write("이번 달은 몇 월인가요 : ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                    break;
                case 1:
                    break;
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("오류! 오류! 오류!");
                    break;

            }
        }
    }
}

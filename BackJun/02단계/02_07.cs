using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._02단계
{
    internal class _02_07
    {
        static void Main7(string[] args)
        {
            // 1~6의 눈을 가진 주사위 3개를 한줄로 입력하시오.
            string[] inputs = Console.ReadLine().Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            int[] dice = { a, b, c };

            // 같은 눈 3개 10000 + (같은 눈)x1,000

            // 같은 눈 2개 1000 + (같은 눈)x100

            // 모두 다른 눈 가장큰눈 x 100

            if (a == b && b == c)
            {
                Console.WriteLine(10000 + a * 1000);
            }
            else if (a != b && b != c && c != a)
            {
                Console.WriteLine(dice.Max() * 100);
            }
            else
            {
                if (a == b)
                {
                    Console.WriteLine(1000 + a * 100);
                }
                else if (b == c)
                {
                    Console.WriteLine(1000 + b * 100);
                }
                else
                {
                    Console.WriteLine(1000 + c * 100);
                }
            }
        }
    }
}

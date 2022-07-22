using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_08
    {
        static void Main1(string[] args)
        {
            string input = Console.ReadLine();

            //65  ~ 90      A~Z 아스키 코드

            //input[0] -> char 형태 -> int형태로 바꾸고 싶다.

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input == "\n")
                    break;

                if (input[i] < 68)
                {
                    sum += 3;
                }
                else if (input[i] < 71)
                {
                    sum += 4;
                }
                else if (input[i]  < 74)
                {
                    sum += 5;
                }
                else if (input[i]  < 77)
                {
                    sum += 6;
                }
                else if (input[i] < 80)
                {
                    sum += 7;
                }
                else if (input[i] < 84)   // 문자열이 4개 이다... 문제를 꼼꼼히 볼 것
                {
                    sum += 8;
                }
                else if (input[i] < 87)
                {
                    sum += 9;
                }
                else 
                {
                    sum += 10;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

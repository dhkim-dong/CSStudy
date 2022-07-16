using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_14
    {
        static void Main14(string[] args)
        {
            while (true)
            {

            }

            int input = int.Parse(Console.ReadLine());

            int result1 = input;
            int result2;
            int result3;
            // (1) 주어진 수가 10보다 작으면 앞에 10을 곱하세요.
            if (result1 < 10)
                result1 *= 10;

            int ten = result1 / 10;
            int one = result1 % 10;
            // (2) 10의 자리수와 1의 자리수를 더하세요.
            result2 = ten + one;

            // (3) 1번 값의 1의 자리수*10 (2)에서 만들어진 값의 일의 자리수를 더하세요.
            result3 = ten * 10 + result2 % 10;


            // (4) 위 방법을 반복하세요 기존의 값으로 돌아오는 N값을 구하세요.
            Console.WriteLine("집에서 한 것");
        }
    }
}

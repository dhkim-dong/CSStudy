using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_15
    {
        static void Main1(string[] args)
        {
            // 첫째 줄 금액 X
            // 둘째 줄 물건 종류의 수 N
            // N개의 줄 가격 a와 개수 b가 주어진다.

            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] inputs= Console.ReadLine().Split();
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                X -= a * b;
            }

            if (X == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_02
    {
        static void Main2(string[] args)
        {
            // 많이 틀린 이유 : 알고리즘 테스트 AI가 스스로 값을 입력하는 형식임을 생각해야한다.
            // 테스트 없이 혼자서 랜덤으로 값을 호출하는 코딩을 작성하여 오답으로 처리됨!

            // 두 정수 A와 B를 입력받으세요

            int input = int.Parse(Console.ReadLine());
            // input 수만큼 T가 생긴다. T갯수만큼 0<a,b<10 a,b조합을 생성한후 a+b를 출력하라.

            for (int i = 0; i < input; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                Console.WriteLine($"{a + b}");
            }
        }
    }
}

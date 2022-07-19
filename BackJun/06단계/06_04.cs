using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_04
    {
        static void Main4(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            // 테스트 케이스는 반복횟수 + 문자열 S로 구성

            for (int t = 0; t < T; t++)
            {
                while (true)
                {
                    string[] inputs = Console.ReadLine().Split();

                    // string의 해당하는 각각의 값을 N번 출력한다

                    int reCount = int.Parse(inputs[0]);

                    string str = inputs[1];
                    string[] result = new string[str.Length];

                    for (int i = 0; i < str.Length; i++)
                    {
                        for (int j = 0; j < reCount; j++)
                        {
                            result[i] += str[i].ToString();
                        }
                    }

                    for (int i = 0; i < str.Length; i++)
                    {
                        Console.Write(result[i]);
                    }
                    Console.WriteLine();
                    break;
                }
            }        
        }
    }
}

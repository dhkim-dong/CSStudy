using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._12단계
{
    internal class _12_7
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            // 부분 문자열을 구하시오.

            // 0번째 열부터 시작해서 끝까지 string합친 것을 출력 

            HashSet<string> setS = new HashSet<string>();

            // if( S) == "ababc"

            string temp = null;

            for (int x = 0; x < S.Length; x++)
            {
                for (int y = 0; y < S.Length; y++)
                {
                    if (x + y > S.Length)
                        break;

                    temp = S.Substring(x, y);
                    setS.Add(temp);
                    temp = null;
                }
            }

            Console.WriteLine(setS.Count);
        }
    }
}

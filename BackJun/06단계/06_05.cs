using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_05
    {
        static void Main(string[] args)
        { 
            int distAlpha = 97 - 65;          // 32

            //Console.WriteLine(r1);          //65  대문자 ~  90             (25개)
            //Console.WriteLine(r2);          //97  소문자 ~ 122
        
            // 문자열로 바꾼후에 Upper를 사용하면 된다.

            string input = Console.ReadLine();

            string Upper = input.ToUpper();

            int[] count = new int[26];



            for (int i = 0; i < Upper.Length; i++)
            {               
                for (int x = 0; x < 26; x++)
                {
                    int alpha = 65 + x;
                    if (Upper[i] == alpha)
                    {
                        count[x]++;
                    }
                }             
            }

            int result = count.Max();

            Console.WriteLine(Upper[count.Max()]);

            // 가장 많이 사용된 알파벳(int)값 -> (char)형변환해서 출력 또는 중복된 max값 "?"출력하세요.

        }
    }
}

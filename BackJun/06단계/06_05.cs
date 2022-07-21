using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_05
    {
        static void Main1(string[] args)
        { 
            int distAlpha = 97 - 65;          // 32

            //Console.WriteLine(r1);          //65  대문자 ~  90             (25개)
            //Console.WriteLine(r2);          //97  소문자 ~ 122


            // 문자열로 바꾼후에 Upper를 사용하면 된다.

            string input = Console.ReadLine();

            string Upper = input.ToUpper();

            int[] count = new int[26];



            // A부터 Z까지 담을 배열 하나를 생성하세요.

            char[] chars = new char[26];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(65+i);
            }

            for (int i = 0; i < Upper.Length; i++)
            {               
                for (int x = 0; x < 26; x++)
                {
                    int alpha = 65 + x;
                    if ((int)Upper[i] == alpha)
                    {
                        count[x]++;
                    }
                }             
            }

            // count의 배열 중에서 가장 큰 int값을 구하고 싶다.

            int maxValue = count.Max();
            int maxIndex = Array.IndexOf(count,maxValue);

            // 최대값이 중복되는지 확인하는 변수.
            bool same = false;
            bool first = false;
            // 중복된 값이 있으면 "?" 출력하시오.
            for (int i = 0; i < count.Length; i++)
            {
                if(first == true)
                {
                    if (count[i] == maxValue)
                    {
                        same = true;
                    }
                }
                if(count[i] == maxValue)
                {
                    first = true;
                }
            }

            if(same == true)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(chars[maxIndex]);
            }

            // 가장 많이 사용된 알파벳(int)값 -> (char)형변환해서 출력 또는 중복된 max값 "?"출력하세요.

        }
    }
}

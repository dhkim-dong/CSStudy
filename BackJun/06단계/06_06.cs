using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_06
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine().Trim();

            // 문자열 내에서 " " 띄어쓰기 한 부분을 찾아서 +1을 하면 단어의 개수를 찾을 수 있다.

            // asdvavd" "asdfasfd" 'asdf" "asdf" "afdaa" ";

            // 문자열 내에서 " " 찾기
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    count++;
                }
            }

            if(input.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(count + 1);
            }
        }
    }
}

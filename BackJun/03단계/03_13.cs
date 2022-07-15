using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_13
    {
        static void Main13(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();  // inputs로 한 번에 묶을 수 없는 이유 : text파일이 없기 때문에 배열로 표현 할 이유가 없다.
                if (input == null) break;           //EOF : End of File 입력값이 끝났음을 알리세요
                StringBuilder sb = new StringBuilder();
                string[] inputs = input.Split();      
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                sb.Append((a + b).ToString());
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }
    }
}

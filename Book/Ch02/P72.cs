using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P72
    {
        static void Main13(string[] args)
        {
            Console.WriteLine("코드 2-17 예외");
            Console.WriteLine("안녕하세요"[100]); // 문자열을 초과하는 참조를 불러올 경우에 null exception 버그가 발생 = 터진다.
        }
    }
}

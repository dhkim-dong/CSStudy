using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P78
    {
        static void Main17(string[] args)
        {
            Console.WriteLine("코드 2-22 불과 논리 연산자");
            Console.WriteLine(DateTime.Now.Hour); // 현재 시간을 나타나는 값 형식 DateTime의 프로퍼티 Now의 프로퍼티 Hour
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Hour > 3 && 8 > DateTime.Now.Hour);
        }
    }
}

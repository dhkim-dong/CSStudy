using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P107
    {
        static void Main42(string[] args)
        {
            Console.WriteLine("코드 2-57");
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            Console.WriteLine("코드 2-58");

            long longNum = 21345646587878656L + 4567864654L;
            int intNum = (int)longNum;   // casting을 통해 강제 형변환은 가능하지만 int가 담을 수 있는 크기보다 큰 데이터를 넣으면 데이터의 손실이 발생한다.
            Console.WriteLine(intNum);
        }
    }
}

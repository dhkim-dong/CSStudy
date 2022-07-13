using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P106
    {
        static void Main41(string[] args)
        {
            Console.WriteLine("코드 2-56");

            long longNumber = 2147483647L + 2147483647L;
            //int intNum = longNumber;     // 같은 정수형 데이터라도 자신보다 작은 데이터 크기의 자료형에 넣으면 에러가 발생한다. -> casting을 해야함.   
            //Console.WriteLine(intNum);
        }
    }
}

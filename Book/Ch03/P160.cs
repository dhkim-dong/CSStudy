using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P160
    {
        static void Main16(string[] args)
        {
            Console.WriteLine("코드 4-6");
            int[] intArray = { 52, 273, 62, 65, 103 };
            Console.WriteLine(intArray[4]);
            //Console.WriteLine(intArray[5]);   // 배열은 0부터 시작, 선언한 배열보다 큰 원소를 호출하면 예외오류가 발생한다.
        }
    }
}

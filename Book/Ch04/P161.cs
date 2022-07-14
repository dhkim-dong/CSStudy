using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P161
    {
        static void Main17(string[] args)
        {
            Console.WriteLine("코드 4-7");
            int[] array = new int[100];  // 크기가 100이고 int 데이터형을 담는 변수 array를 생성하였다.

            Console.WriteLine("코드 4-8");
            int[] intArray = new int[100];

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]); // 생성만 하고 초기화를 하지 않으면 0의 값이 들어간다.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P187
    {
        static void Main37(string[] args)
        {
            Console.WriteLine("코드 4-31");
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);                            // Thread 스택틱 클래스의 한정 메서드
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");


            Console.WriteLine("코드 4-32");
            int x = 1;
            while(x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if(x%3 == 0) // 3의 배수라면
                    Console.WriteLine("__@");
                else if(x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");
                Thread.Sleep(100);
                x++;                                      // 움직이는 달팽이를 콘솔창에서 구현하기.
            }
        }
    }
}

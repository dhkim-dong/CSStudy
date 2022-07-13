using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    /* 
   *  날짜 : 2022/0713
   *  이름 : 김동훈
   *  내용 : 조건문 if 실습하기 교재 p127
   */
    internal class _1_if문
    {
        static void Main1(string[] args)
        {
            //if
            int num1 = 1;
            int num2 = 2;

            if (num1 < num2)
            {
                // 조건이 참이면 실행
                Console.WriteLine("num1 이 num2 보다 작다.");
            }
            if ( num1 < 0)
            {
                Console.WriteLine("num1은 0보다 작다.");
            }

            // 중첩 if문   -> 중첩 코드는 가독성이 떨어진다. 간결하게 할 방법이 없을까? -> 논리연산자 &&와 함께 사용해본다.
            if (num1 > 0)
            {
                if (num2 > 1)
                {
                    Console.WriteLine("num1은 0보다 크고, num2는 1보다 크다.");
                }
            }

            if (num1 >0 && num2 > 1)    
            {
                Console.WriteLine("num1은 0보다 크고, num2는 1보다 크다.");
            }

            //if ~ else
            int var1 = 1, var2 = 2;

            if (var1 > var2)
            {
                Console.WriteLine("var1 이 var2보다 크다.");
            }
            else
            {
                Console.WriteLine("var1 이 var2보다 작다.");
            }

            //if ~ else if ~ else

            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            if (n1 > n2)
            {
                Console.WriteLine("n1이 n2보다 크다.");
            }
            else if (n2 > n3)   // 조건이 참이면 조건문이 종료된다.
            {
                Console.WriteLine("n2이 n3보다 크다.");
            }
            else if (n3 > n4)
            {
                Console.WriteLine("n3이 n4보다 크다.");
            }
            else
            {
                Console.WriteLine("n4가 가장 크다");
            }
        }
    }
}

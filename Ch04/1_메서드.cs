using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    /*
     * 날짜 : 2022/07/14
     * 이름 : 김동훈
     * 내용 : 메서드 실습하기 교재 p256
     *
     * 메서드(Method)
     *  - 일련의 코드 로직을 재활용하기 위해 모듈화된 구조체
     *  - 메서드는 정의(Define),
     */
namespace Ch04
{
    internal class _1_메서드
    {
        static void Main1(string[] args)        // static 메서드 안에서 메서드를 사용하기 위해서는 static 형태여야 한다.
        {
            // 메서드 호출
            int y1 = F(1);                              // 1. 변수 선언 2. 메서드 실행 3. 반환값 대입
            int y2 = F(2);                              // static 메서드는 클래스없이 바로 호출할 수 있다.
            int y3 = F(3);
            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);
            Console.WriteLine("y3 : " + y3);

            // 메서드 호출
            int t1 = Sum(1, 10);
            int t2 = Sum(3, 16);
            int t3 = Sum(start: 1, end: 124);               // 매개 변수를 선언해서 값을 대입할 수도 있다.
            int t4 = Sum(end: 20, start: 2);
            Console.WriteLine("t1 : " + t1);
            Console.WriteLine("t2 : " + t2);
            Console.WriteLine("t3 : " + t3);
            Console.WriteLine("t4 : " + t4);

        } // 코드 블럭이 끝나는 곳이 메서드의 끝

        public static int F(int x)                 // f메서드의 실행 
        {
            int y = 2 * x + 3;
            return y;
        }

        // 메서드 정의

        public static int Sum(int start, int end)            // 틀을 만드는 것 (선언) 내용을 만드는 것 (정의) C#에서 메서드의 이름을 대문자로 시작하는 RULE이 있다.  C,C++,C#은 대문자 / 나머지 언어는 소문자
        {
            int total = 0;

            for (int k = start; k <= end; k++)                // start ~ end까지 더하는 메서드
            {
                total += k;
            }
            return total;                                    // 반환값의 자료 타입을 선언해준다.
        }
    }
}

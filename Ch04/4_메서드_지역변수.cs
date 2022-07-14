using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김동훈
 * 내용 : 메서드 지역변수 실습하기 교재 p275
 * 
 * 전역변수(Global Variable)
 * - 모든 메서드에서 참조할 수 있는 변수
 * - 객체지향프로그래밍에서 전역변수는 멤버변수(속성) 이다.
 * 지역변수(Local Variable)
 * - 특정 메서드에서 선언한 변수로 해당 메서드에서만 참조할 수 있다.
 * - 해당 메서드가 끝날 때 Pop된다. (Stack에서 사라진다.)
 */

namespace Ch04
{
    internal class _4_메서드_지역변수
    {
        // 전역변수 : 클래스의 멤버변수로서 
        static int result = 0; // 제일 마지막에 Pop 된다. (Main메서드가 끝날 때)

        static void Main4(string[] args)
        {
            // 지역 변수
            int n1 = 1;
            int n2 = 10;

            int result = Sum(n1, n2);

            Console.WriteLine("result :" + result);
        } // end of Main

        public static int Sum(int start, int end)
        {
            int total = 0;

            for (int k = start; k <= end; k++)
            {
                total += k;
            }
            return total;
        }
    }
}

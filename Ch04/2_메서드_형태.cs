using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   /*
    * 날짜 : 2022/07/14
    * 이름 : 김동훈
    * 내용 : 메서드 타입 실습하기 교재 p265
    * 추가 : 메서드와 함수의 차이 : 메서드는 함수의 일종이지만, 클래스 안에서 기능하는 녀석을 메서드라고 부른다.
    */
namespace Ch04
{

    internal class _2_메서드_형태             // 클래스의 첫 이름도 대문자로 선언한다. // 변수는 소문자로 선언한다.
    {
        static void Main2(string[] args)
        {
           double y1 = Type1(0.5);             // 매개변수로 들어온 값을 인자값이라고 한다. 인자값 전달
           double y2 = Type1(0.13);

            Console.WriteLine("y1 : "+y1);
            Console.WriteLine("y2 : "+y2);

            Type2(true);                      // 변수 선언? : 반환값이 있을 경우에만 -> 메서드 실행 -> 대입 (반환값이 있을 경우에만)
            Type2(false);

            string rs1 = Type3();
            Console.WriteLine("Type3 result : " + rs1);

            Type4();
        }

        //Type1 : 매개변수 0, 리턴값 0
        public static double Type1(double x)
        {
            double y = x + Math.PI;
            return y;
        }
        //Type1 : 매개변수 0, 리턴값 X
        public static void Type2(bool status)
        {
            if (status)
            {
                Console.WriteLine("참 입니다.");
            }
            else
            {
                Console.WriteLine("거짓 입니다.");
            }
        }
        //Type1 : 매개변수 X, 리턴값 0
        public static string Type3()
        {
            int n1 = 1;
            int n2 = 2;

            if (n1 > n2)
            {
                return "n1은 n2보다 크다.";
            }
            else
            {
                return "n1은 n2보다 작다.";
            }
        }
        //Type1 : 매개변수 X, 리턴값 X
        public static void Type4()
        {
            Console.WriteLine("Type4 result : "+ Type1(1.12));
        }
    }
}

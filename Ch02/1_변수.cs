using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    internal class _1_변수
    {
        //상수 : 한번 저장된 데이터를 변경할 수 없는 데이터이다

        //날짜 : 2022/07/12
        //이름 : 김동훈
        //내용 : 변수 실습하기 교재 P79

        //변수(Variable)
        //- 데이터를 처리하기 위한 데이터 그릇
        //- 데이터를 처리하기 위한 데이터 그릇
        //- 변수는 메모리상에 생성되는 공간
        //상수(Constant)
        //- 데이터를 변경할 수 없는 변수
        //- 최초 저장(초기화)된 데이터를 고정

        static void Main1(string[] args)
        {
            int num1; // 선언
            num1 = 1; // 값 할당

            int num2 = 2; // 선언과 초기화

            int num3 = num1 + num2; // 데이터 처리 연산

            Console.WriteLine("num3 : " + num3);

            const int NUM = 10; // const 
            // NUM = 20; 상수의 값을 변경하려고 하면 에러가 난다.
            // 상수는 대문자로 표현한다.
            // 상수는 다른 값이 들어올수 없도록 고정시키는 것

            const double PI = 3.14;

            Console.WriteLine("PI : " + PI);
            Console.WriteLine("NUM : " + NUM);
        }
    }
}

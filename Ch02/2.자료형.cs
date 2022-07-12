using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    //날짜 : 2022/07/12
    //이름 : 김동훈 
    //내용 : 자료형 실습하기 교재 p63
    //자료형(Data Type)
    //- 변수에 저장되는 데이터의 종류와 크기를 자료형으로 선언
    //- 자료형은 크게 기본형과 참조형으로 나뉨

    internal class _2
    {
        static void Main2(string[] args)
        {
            // 기본자료형
            // 정수형
            sbyte num1 = 127;
            short num2 = 32767;
            int num3 = 2147483647;
            long num4 = 92233720368477507L;                               
            
            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);            
            Console.WriteLine("num3 : {0}", num3);
            Console.WriteLine("num4 : {0}", num4);

            // 실수형
            float var1 = 0.1234567895f;// 8자리 질문
            double var2 = 0.123456790123777777; // 반올림된다.

            Console.WriteLine("var 1 " + var1);
            Console.WriteLine("var 2 " + var2);

            // 논리형
            bool b1 = true;
            bool b2 = false;

            Console.WriteLine("b1 : " + b1);
            Console.WriteLine("b2 : " + b2);

            // 문자형
            char c1 = 'A';
            char c2 = '가';  // 자음 모음 1개씩만 저장가능

            Console.WriteLine("c1 : " + c1);
            Console.WriteLine("c2 : " + c2);
            // 문자열
            string str1 = "A";
            string str2 = "가";
            string str3 = "Apple";
            string str4 = "안녕하세요.";
            string str5 = "10";

            Console.WriteLine("str1 : " + str1);
            Console.WriteLine("str2 : " + str2);
            Console.WriteLine("str3 : " + str3);
            Console.WriteLine("str4 : " + str4);
            Console.WriteLine("str5 : " + str5);

            // object 형
            // 객체로 저장한다.

            object newObejct = new object();
            object obj1 = 10;
            object obj2 = 3.14;
            object obj3 = true;
            object obj4 = 'A';
            object obj5 = "Apple";

            Console.WriteLine("obj1 : "+obj1);
            Console.WriteLine("obj2 : "+obj2);
            Console.WriteLine("obj3 : "+obj3);
            Console.WriteLine("obj4 : "+obj4);
            Console.WriteLine("obj5 : "+obj5);

            // var형

            var v1 = 10;
            var v2 = 3.14;
            var v3 = true;
            var v4 = 'A';
            var v5 = "Apple";
            Console.WriteLine("var1 : "+v1);
            Console.WriteLine("var2 : "+v2);
            Console.WriteLine("var3 : "+v3);
            Console.WriteLine("var4 : "+v4);
            Console.WriteLine("var5 : "+v5);
        }
    }
}

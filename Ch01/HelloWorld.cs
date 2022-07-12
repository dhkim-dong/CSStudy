using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01
{
    class HelloWorld
    {
        //날짜 : 2022년 07월 12
        //이름 : 김동훈
        //내용 : C# 개발환경 설정, Hello World 출력 교재 P44


        // svm tab tab 자동완성

        static void Main(string[] args)
        {
            //cw tab tab
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Korea");

            // 서식 출력
            // 한 줄 복사 : Ctrl + D
            // 서식 문자
            // \t : tab
            // \n : new line
            Console.Write("Hello\t");
            Console.Write("Korea\n");
            Console.Write("Korea\n");

            // 포맷출력
            Console.WriteLine("{0},{1}","Hello","Busan");
            Console.WriteLine("{0},{1}","Hello","Busan");

        }
    }
}

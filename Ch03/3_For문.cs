using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    /*
     * 날짜 : 2022/07/13
     * 이름 : 김동훈
     * 내용 : 반복문 for 실습하기 교재 p157 
     * 
    */
    internal class _3_For문
    {
        static void Main(string[] args)
        {
            // for 
            for (int i = 1; i <= 5; i++)   // 초기식 ;조건식 ; 증감식;
            {
                Console.WriteLine(i+"회 반복...");
            }
            // 1부터 10까지 합

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine(i+ "회 전체 합 : " + sum);
            }

            // 1부터 10까지 짝수합
            int tot = 0;
            for (int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    tot += i;
                }
                Console.WriteLine(i + "회 전체 합 : " + tot);
            }

            // 중첩 for문                  전체 12번
            for (int y =1; y <= 3; y++)
            {
                Console.WriteLine("");
                Console.WriteLine("y : " + y);
                for (int x = 1; x <= 4 ; x++)
                {
                    Console.Write("x : "+ x + " ");
                }
            }
            // 구구단
            for (int x = 2; x <= 9 ; x++)
            {
                Console.WriteLine("");
                Console.WriteLine("{0}단", x);
                for (int y = 1; y <= 9; y++)
                {
                    int z = x * y;
                    Console.WriteLine("{0} x {1} = {2}",x,y,z);
                    //Console.WriteLine($"{x} x {y} = {z}");
                }
            }

            // 별삼각형
            for (int start = 1; start <= 10; start++)
            {
                for (int end = 1; end <= start; end++)
                {
                    Console.Write("★");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("역삼각형입니다");

            for (int y = 0; y < 10; y++)
            {
                for (int x = 10; x > y; x--)
                {
                    Console.Write("★");
                }
                Console.WriteLine("");
            }
        }
    }
}

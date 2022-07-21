using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/07/21
 * 이름 : 김동훈
 * 내용 : 자주 사용하는 내장 클래스 실습하기
 * 
 */

namespace Ch06
{
    internal class _6_내장클래스
    {
        static void Main1(string[] args)
        {
            //// Math 클래스
            Console.WriteLine("PI : " + Math.PI);
            Console.WriteLine("9 제곱근 : " + Math.Sqrt(9));
            Console.WriteLine("16 제곱근 : " + Math.Sqrt(16));
            Console.WriteLine("-16 절대값 : " + Math.Abs(-16));
            Console.WriteLine("16.1616의 올림 : " + Math.Ceiling(16.1616));
            Console.WriteLine("16.1616의 내림 : " + Math.Floor(16.1616));
            Console.WriteLine("16.1616의 반올림 : " + Math.Round(16.1616));
            Console.WriteLine();

            //// Random 클래스
            Random rand = new Random();

            double num1 = rand.NextDouble();
            Console.WriteLine("num1 : "+ num1); // 0 ~ 1 사이의 임의의 실수

            double num2 = num1 * 10;
            Console.WriteLine("num2 : "+ num2); // 0~ 10 사이의 임의의 실수

            double num3 = Math.Ceiling(num2); // 1~10 사이의 임의의 정수
            Console.WriteLine("num3 : "+ num3);

            int rNum1 =rand.Next();
            Console.WriteLine("rNum1 : "+ rNum1);
            int rNum2 =rand.Next(10); // 0~9 사이의 임의의 정수
            Console.WriteLine("rNum2 : "+ rNum2);
            int rNum3 = rand.Next(5, 10); // Next( )안의 매개 변수는 index번호 (-> 시작 번호가 0이다.)임을 인지할 것!!
            Console.WriteLine("rNum3 : "+ rNum3);


            //// DateTime 클래스 : 대표적인 싱글톤 객체이다. C#에서는 구조체로 선언되어 있다.

            DateTime dt = DateTime.Now;

            Console.WriteLine("dt : " + dt);
            Console.WriteLine("년 : " + dt.Year);
            Console.WriteLine("월 : " + dt.Month);
            Console.WriteLine("일 : " + dt.Day);
            Console.WriteLine("시 : " + dt.Hour);
            Console.WriteLine("분 : " + dt.Minute);
            Console.WriteLine("초 : " + dt.Second);

            // 문자열 format을 이용한 날짜 출력
            string result1 = dt.ToString("yyyy-MM-dd");
            Console.WriteLine("result1 : "+ result1);

            string result2 = dt.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine("result2 : "+ result2);
        }
    }
}

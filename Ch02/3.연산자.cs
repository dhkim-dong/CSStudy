using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    /*
     * 날짜 : 2022/07/12
     * 이름 : 김동훈
     * 내용 : 연산자 실습하기 교재 p90
     * 
     * 연산자(Operator)
     * - 변수에 저장된 데이터를 가공하기 위해 연산자를 사용
     * - 연산자는 크게 산술, 증감, 복합대입, 비교, 논리 연산자 등이 있다.
     * */

    internal class _3
    {
        static void Main3(string[] args)
        {
            //산술 연산자
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            int r1 = num1 + num2;
            int r2 = num1 - num2;
            int r3 = num1 * num2;
            int r4 = num1 / num2;
            int r5 = num4 % num3; // 나머지를 구하는 연산자


            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);
            Console.WriteLine("r5 : " + r5);

            //증감 연산자
            int num = 0;

            num++;
            ++num;

            Console.WriteLine($"num : {num}");

            num--;
            --num;
            Console.WriteLine("num : {0}", num);

            //복합대입 연산자
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4; // 자료형을 초기화는 것

            n1 += 1;
            n2 -= 2;
            n3 *= 3;
            n4 /= 4;

            Console.WriteLine("n1 : " +n1);
            Console.WriteLine("n2 : " +n2);
            Console.WriteLine("n3 : " +n3);
            Console.WriteLine("n4 : " +n4);

            //비교 연산자
            int var1 = 1;
            int var2 = 2;

            bool result1 = var1 > var2;
            bool result2 = var1 < var2;
            bool result3 = var1 == var2;
            bool result4 = var1 != var2;
            bool result5 = var1 >= var2;
            bool result6 = var1 <= var2;

            Console.WriteLine("result1 : "+result1);
            Console.WriteLine("result2 : "+result2);
            Console.WriteLine("result3 : "+result3);
            Console.WriteLine("result4 : "+result4);
            Console.WriteLine($"result5 : {result5}");
            Console.WriteLine($"result6 : {result6}");
            //논리 연산자
            bool re1 = var1 > 1 && var2 > 2; // var1은 1보다 크면서 var2도 2보다 큰가? true or false
            bool re2 = var1 > 0 && var2 > 1; // 
            bool re3 = var1 > 1 || var2 > 2; // var1은 1보다 크고 또는 var은 2보다 큰가?
            bool re4 = var1 > 0 || var2 > 2;
            bool re5 = !(var1 > var2); // var1이  var2보다 크다? 의 반대 값

            Console.WriteLine("re1 : "+re1);
            Console.WriteLine($"re2 : {re2}");
            Console.WriteLine($"re3 : {re3}");
            Console.WriteLine($"re4 : {re4}");
            Console.WriteLine($"re5 : {re5}");

            //조건 연산자
            int number = 1;

            string result = (number > 1) ? "참입니다" : "거짓입니다.";    //  삼항연산자 : (조건) ? "조건이 참 일때" : " 조건이 거짓일 때"
            int resultt = (number > 1)? 1 :2;

            Console.WriteLine("result : "+ result);
            Console.WriteLine("resultt : " + resultt);
        }
    }
}

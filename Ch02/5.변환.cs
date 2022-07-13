using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    /*
     * 날짜 : 2022/07/13
     * 이름 : 김동훈
     * 내용 : 데이터 변환 형식 실습하기 교재 p106
     * 
     * */

    // 생활코딩

    internal class _5
    {
        static void Main5(string[] args)
        {
            // 작은 변수에서 큰 변수         작은 자료형에서 큰 자료형으로 넣는 것은 문제가 없지만
            byte num1 = 255;    // 1byte
            short num2 = num1;  // 2byte
            int num3 = num2;    // 4byte

            Console.WriteLine("num 1 : {0}", num1);
            Console.WriteLine("num 2 : {0}", num2);
            Console.WriteLine("num 3 : {0}", num3);

            // 큰 변수에서 작은 변수로 데이터 이동    큰 자료형에서 작은 자료형으로 데이터를 넣을 때 오류가 발생한다. -> 해결하기 위해서 casting 사용한다 -> 클래스(객체) 형변환에서도 다시 쓰인다.

            int var1 = 256;
            short var2 = (short) var1; // casting 강제 형변환
            byte var3 = (byte)var2;    // 0~255 값이 넘친다.
            Console.WriteLine("var1 : "+ var1);
            Console.WriteLine("var2 : "+ var2);
            Console.WriteLine("var3 : "+ var3);

            // 정수에서 실수            (1) 데이터의 크기는 문제가 없다  (2) 자료의 타입 (자료형)이 다르다.  
            int a = 1;   // 4byte
            int b = 2;
            int c = 3;

            double d1 = a; // 8byte
            double d2 = b;
            double d3 = c;

            Console.WriteLine("d1 : " + d1);
            Console.WriteLine("d2 : " + d2);             // 개념적으로는 2.000000000000000이출력되는 것이 맞다
            Console.WriteLine("d3 : " + d3);             // ?? 왜 3.0으로 출력이 안될까?

            // 실수에서 정수
            double n1 = 1.2;
            double n2 = 2.14;
            double n3 = 12.123;

            int r1 = (int)n1;
            int r2 = (int)n2;
            int r3 = (int)n3;

            Console.WriteLine("r1 : " +r1);
            Console.WriteLine("r2 : " +r2);
            Console.WriteLine("r3 : " +r3);
        }
    }
}

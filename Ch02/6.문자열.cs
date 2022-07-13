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
     * 내용 : 문자열 실습하기 교재 p112 
     * 
     * */

    internal class _6
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine(greeting);
            Console.WriteLine();

            // 문자열 길이
            Console.WriteLine("길이 : "+ greeting.Length); // 문자의 갯수   
            Console.WriteLine();

            // 문자열 추출
            Console.WriteLine("greeting 1번째 문자 : " + greeting[0]);
            Console.WriteLine("greeting 5번째 문자 : " + greeting[4]);
            Console.WriteLine("greeting 12번째 문자 : " + greeting[11]);

            // 문자열 index 문자열에서 각 순서번호를 인덱스라고 한다.
            Console.WriteLine("'G' 인덱스 : " + greeting.IndexOf('G'));
            Console.WriteLine("'M' 인덱스 : " + greeting.IndexOf('M'));
            Console.WriteLine("'o' 인덱스 : " + greeting.IndexOf('o'));  // 인덱스는 앞에서 부터 찾는다.
            Console.WriteLine("'o' 인덱스 : " + greeting.LastIndexOf('o'));  // 문자열 클래스의 LastIndexof 메소드 -> 문자열의 뒤에서 부터 찾는다.
            Console.WriteLine("");

            // 문자열 자르기
            Console.WriteLine("greeting 0 ~4 까지 문자열 : "+ greeting.Substring(0,5));  // 문자열 클래스의 substring 메소드(int StartNum, int length) -> 문자열 배열의 시작번호, 몇개?
            Console.WriteLine("greeting 5 ~7 까지 문자열 : "+ greeting.Substring(5,7));
            Console.WriteLine("greeting 3 ~마지막 까지 문자열 : "+ greeting.Substring(0));
            // 문자열 교체
            string replaced = greeting.Replace("Morning", "Afternoon"); // 문자열 greeting의 Replace()메소드를 이용해서 "변환한 값"을 또 다른 변수 replaced에 옮겨닮는다.
            Console.WriteLine("replaced : " + replaced);
            replaced = "Good Night";

            Console.WriteLine("greeting: " + greeting); // 메소드에서 발생한 데이터는 스택단계에서 사라지기 때문에 greeting 참조 값에는 영향이 없다.
            Console.WriteLine();
            // 문자열 변환
            int var1 = 1;                    // 같은 데이터 크기 , 다른 자료형으로 옮기고 싶다. casting을 사용했다 -> 에러
            double var2 = 2.12345;
            bool var3 = true;
            string str1 = "" + var1;  // int 자료형(struct)의 Tostirng() 메서드를 사용해서 string 형태로 바꾸어준다.
            string str2 = var2.ToString(); //  
            string str3 = "" + var3;   // 자료형의 메서드를 사용하지 않고 ""+ 변수 형태로도 문자열 변환이 가능하다. 

            Console.WriteLine("str1 : " + str1); // 출력되는 값은 숫자가 아니라 문자다.
            Console.WriteLine("str2 : " + str2);
            Console.WriteLine("str3 : " + str3);

            string s1 = "100";              // 문자열의 "(안)"의 값을 빼오고 싶다.
            string s2 = "3.14";
            string s3 = "false";

            int r1 = int.Parse(s1);        // int자료형의 parse(string)메소드
            double r2 = double.Parse(s2);
            bool r3 = bool.Parse(s3);

            int r4 = Convert.ToInt32(s1); // static 클래스인 Convert(객체 없이 호출 가능)의 Toint32() 매서드를 호출하여, int형 변수 r4에 값을 저장한다.

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);
        }
    }
}

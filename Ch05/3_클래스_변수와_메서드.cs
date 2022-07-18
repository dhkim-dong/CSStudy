using Ch05.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/07/18 
 * 이름 : 김동훈
 * 내용 : 클래스 변수, 클래스 메서드 실습하기 교재 p225 
 * 
 * 클래스 변수, 클래스 메서드
 * - 클래스 변수와 클래스 메서드는 static을 선언한 변수와 메서드로 Data 영역 메모리 공간에 하나의 클래스로 관리
 * - 클래스 이름으로 직접 참조하거나 호출한다.
 * 
 * ★ 싱글톤 ★
 */


namespace Ch05
{
    class Increment
    {
        public int num1;

        // Data 영역에 따로 관리되는 클래스 변수(정적 변수);
        public static int num2;

        public Increment()
        {
            num1++;
            num2++;
            Console.WriteLine("num1 : {0}, num2 : {1}" , num1, num2);
        }

        // Data 영역에 따로 관리되는 클래스 메서드 (정적 메서드)
        public static void Add()
        {
            // 정적 메서드(static 클래스)는 non-static 변수를 참조할 수 없다.
            //num1++;
            num2++;

            Console.WriteLine("num2 : {0}", num2);
        }
    }



    internal class _3_클래스_변수와_메서드
    {
        static void Main(string[] args)      
        {
            Increment inc1 = new Increment();
            Increment inc2 = new Increment();
            Increment inc3 = new Increment();

            // 클래스 변수 참조
            Increment.num2 = 2;


            // 클래스 메서드 실행
            Increment.Add();

            // 클래스 변수를 활용한 객체
            Car car1 = new Car("소나타", "검정", 0);                 // primary Index 느낌으로 정적 변수를 사용한다.
            car1.Show();
            Car car2 = new Car("아반테", "검정", 0);
            car2.Show();
            Car car3 = new Car("싼타페", "검정", 0);
            car3.Show();


            // 싱글톤 객체 : 굳이 다양한 객체를 만들 필요하기 있을까? 단일 객체로 사용할 수 있으면 좋겠다.
            // 가장 대표적인 싱글톤 객체 : 날짜

            Calc cal = Calc.Instance;
            //Calc c = new Calc(); // 못하게 막아야한다. private 생성자를 통해서 막음.

            int r1 = cal.Plus(1, 2);
            int r2 = cal.Minus(1, 2);
            int r3 = cal.Multi(2, 3);
            int r4 = cal.Div(4, 2);

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);
        }
    }
}

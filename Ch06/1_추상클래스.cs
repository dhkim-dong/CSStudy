using Ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * 날짜 : 2022/07/20
 * 이름 : 김동훈
 * 내용 : 추상클래스 실습하기 교재 P404
 * 
 * 추상클래스(Abstract Class) : 필드와 기능의 통일성을 부여한다.
 * - 공통의 기능은 하나의 메서드로 정의하고 개별적인 기능은 상속 받아 override 메서드로 정의하는 추상메서드를 갖는 클래스
 * - 오직 상속을 목적으로 설계된 클래스
 * - 추상 클래스를 객체 생성할 수 없음
 */


namespace Ch06
{
    internal class _1_추상클래스                            
    {
        // Quiz : 같은 부모를 가지는 자식은 다형성을 가질 수 있다.
        // 유연하게 표현하다. -> 개발자가 보는 관점에서 sedan,truck이 같은 부모(Car)를 갖는 것을 유추할 수 있다.
        static void Main1(string[] args)
        {
            Car sedan = new Sedan("그랜져","검정",0,2000);
            sedan.SpeedDown(80);
            sedan.SpeedUp(100);
            sedan.Show();

            Car truck = new Truck("포터", "파랑", 0, 1);
            truck.SpeedDown(20);
            truck.SpeedUp(80);
            truck.Show();
        }
    }
}

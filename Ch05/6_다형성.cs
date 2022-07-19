using Ch05.Sub5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/07/19 
 * 이름 : 김동훈
 * 내용 : 다형성 실습하기 교재 P340
 * 
 * 다형성(Polymorphism)
 *  - 상속관계에서 부모클래스의 기능이 자식 클래스에서 여려 기능으로 변하는 특성 
 *  - 생성된 객체의 타입을 부모클래스로 선언 
 */
namespace Ch05
{
    internal class _6_다형성
    {
        static void Main(string[] args)
        {
            // 다형성을 적용한 객체 생성      : 왜 타입을 부모클래스로 적용을 해야 하는가?
            Animal a1 = new Tiger();
            Animal a2 = new Eagle();
            Animal a3 = new Shark();

            a1.Move();
            a2.Move();
            a3.Move();

            // 객체 타입 변환(캐스팅)
            Tiger tiger = (Tiger) a1;
            Eagle eagle = a2 as Eagle;
            Shark shark = a3 as Shark;

            tiger.Move();
            eagle.Move();
            shark.Move();

            // 객체 실제 타입 확인
            if (a1 is Tiger)
            {
                Console.WriteLine("a1은 Tiger입니다.");
            }

            if (a2 is Eagle)
            {
                Console.WriteLine("a2은 Eagle입니다.");
            }

            if (a3 is Shark)
            {
                Console.WriteLine("a3은 Shark입니다.");
            }
        }
    }
}

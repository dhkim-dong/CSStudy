using Ch06.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/21
 * 이름 : 김동훈
 * 내용 : 제네릭 실습하기 교재 p395
 * 
 * 제네릭(Generic)
 *  - 클래스 내부의 변수의 타입을 동적으로 일반화 시키는 문법 요소  // 동적? Main에서 실행될 때 타입을 확정받는다.
 *  - 제네릭 사용으로 클래스를 범용성 있게 사용한다.
 */
namespace Ch06
{
    internal class _4_제네릭
    {
        class FruitBox<T> // 제네릭 치환된 클래스       클래스의 타입만을 오버로딩 해야할 때 범용성을 가진 T치환변수를 사용한다. 일반화 시킨다.
        {
            private T fruit; // 일반화 클래스가 있다? 어떤 속성 값에 치환변수 T가 있는지 확인하라!

            public FruitBox(T fruit)
            {
                this.fruit = fruit;
            }

            public T Fruit { get => fruit; }

            public T GetFruit()
            {
                return fruit;
            }
        }


        static void Main1(string[] args)
        {
            Apple apple = new Apple("한국",3000);
            Banana banana = new Banana("대만", 2000);
            FruitBox<Apple> box1 = new FruitBox<Apple>(apple);
            FruitBox<Banana> box2 = new FruitBox<Banana>(banana);

            box1.Fruit.Show();
            box2.Fruit.Show();           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Car
    {
        // 속성(필드) 자식클래스가 참조할 수 있도록 접근 제한자를 protected로 수정
        protected string name;
        protected string color;
        protected int speed;
        //private static int count; // 이 클래스의 멤버가 아니다 
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            //count++;
        }

        // 프로퍼티.. get(),set()메서드..


        // 기능(메서드)
        public void SpeedUp(int _speed) 
        {
            this.speed += _speed;           // this지시자. 가독성UP 멤버변수와 매개변수의 이름을 구별하기 위해서 사용하였다.
        }
        public void SpeedDown(int _speed) 
        {
            this.speed -= _speed;
        }
        public void Show() 
        {
            Console.WriteLine("=========================");
            Console.WriteLine("차량명 " + name);
            Console.WriteLine("차량색 " + color);
            Console.WriteLine("현재속도 " + speed);
            Console.WriteLine("=========================");
        }
    }
}

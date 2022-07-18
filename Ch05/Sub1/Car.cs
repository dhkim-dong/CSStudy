using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Car
    {
        // 속성(필드)
        public string name;
        public string color;
        public int speed;

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

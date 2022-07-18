using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car
    {
        // 속성(필드)
        private string name;
        private string color;
        private int speed;

        // (표준 용어)Getter, Setter : C#에서 '프로퍼티'라고 함
        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Speed 
        {
            get => speed;
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Speed는 0보다 작을 수 없습니다.");
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public Car()      // 메서드 오버로딩
        {

        }

        public Car(string name, string color, int speed)
        {
            this.Name = name;
            this.Color = color;
            this.Speed = speed;
        }

        // 프로퍼티.. get(),set()메서드..


        // 기능(메서드)
        public void SpeedUp(int _speed) 
        {
            this.Speed += _speed;           // this지시자. 가독성UP 멤버변수와 매개변수의 이름을 구별하기 위해서 사용하였다.
        }
        public void SpeedDown(int _speed) 
        {
            this.Speed -= _speed;
        }
        public void Show() 
        {
            Console.WriteLine("=========================");
            Console.WriteLine("차량명 " + Name);
            Console.WriteLine("차량색 " + Color);
            Console.WriteLine("현재속도 " + Speed);
            Console.WriteLine("=========================");
        }
    }
}

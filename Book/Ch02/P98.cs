using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P98
    {
        static void Main34(string[] args)
        {
            Console.WriteLine("코드 2-46 GetType() 메서드 활용");

            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";

            //object NewObject = new Object(); // Object클래스의 Type클래스의 GetType()메소드 기능 : Object에 소속된 자료의 TYPE을 알려준다.

            Console.WriteLine(_int.GetType()); 
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
        }
    }
}

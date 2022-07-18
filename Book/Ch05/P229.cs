using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    class MyMath              // static 메소드는 static 변수만 사용가능하다. 그 이유에 대해서 설명?  데이터 영역에서 가장 먼저 생성되기 때문에, 객체가 생성되기 전에는 존재하지 않는 멤버변수가 참조못하기 때문
    {
        public static double PI = 3.141592;
    }

    class MainApp
    {
        static void Main11(string[] args)
        {
            Console.WriteLine(MyMath.PI);
        }
    }
}

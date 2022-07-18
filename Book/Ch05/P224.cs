using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P224
    {
        class Math                   // static Math 클래스의 식별자와 같은 이름으로 선언하면 static Math를 참조하는 것을 잃는다?
        {
            public string name = "Hi";
        }

        static void Main7(string[] args)
        {
            Math NewMath = new Math();
            Console.WriteLine(NewMath.name);
        }
    }
}

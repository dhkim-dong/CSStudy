using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P371
    {
        abstract class Parent
        {
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        //static void Main(string[] args)
        //{
        //    Parent parent = new Parent();   // 추상 메서드는 인스턴스화 할 수 없다.
        //}
    }
}

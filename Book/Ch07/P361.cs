using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P361
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public new string variable = "hiding";
            public new void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main1(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
        }
    }
}

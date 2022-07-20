using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P354
    {
        class Parent
        {
            public static int counter = 0;

            public void CountParent()
            {
                Parent.counter++;
            }

        }

        class Child : Parent
        {
           public void CountChild()
            {
                Child.counter++;
            }
        }

        static void Main1(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountParent();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
            Console.WriteLine(Child.counter);
        }
    }
}

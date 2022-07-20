using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P370
    {
        class Parent
        {
            public virtual void Test()          
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent                // sealed : Child에 있는  Test메서드를 오버라이드 하지 말 것!
        {
            sealed public override void Test()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        //class GrandChild : Child
        //{
        //    public override void Test()      // Method sealed : 오버라이드 하지 말 것!
        //    {

        //    }
        
    }
}

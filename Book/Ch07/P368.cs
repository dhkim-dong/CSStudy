﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P368
    {
        sealed class Parent
        {
            public void Test()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        //class Child : Parent                // sealed : 절대 상속하지 말 것!
        //{
        //    public  void Method()
        //    {
        //        Console.WriteLine("자식의 메서드");
        //    }
        //}

        //static void Main1(string[] args)
        //{
        //    Child child = new Child();
        //    child.Method();
        //    ((Parent)child).Method();
        //}
    }
}

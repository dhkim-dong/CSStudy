using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class P440
    {

        class Parent { }

        class Child : Parent, IDisposable, IComparable
        {
            public int CompareTo(object? obj)
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

        static void Main1(string[] args)
        {
            Child child = new Child();
        }
    }
}

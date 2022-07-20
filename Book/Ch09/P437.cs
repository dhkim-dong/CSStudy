using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    interface IBasic
    {
        int TestInstanceMethod();
        int TestProperty { get; set; }
    }


    internal class P437
    {
        class TestClass : IBasic
        {
            public int TestProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
        }

        static void Main1(string[] args)
        {
            IBasic basic = new TestClass();
        }
    }
}

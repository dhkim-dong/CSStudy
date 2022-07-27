using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch11
{
    internal class P505
    {
        public delegate void TestDelegate();

        static void Main1(string[] args)
        {
            TestDelegate delegateA = TestMethod;
            TestDelegate delegateB = delegate () { };
            TestDelegate delegateC = () => { };

            delegateA();
            delegateB();
            delegateC();
        }


        static void TestMethod()
        {

        }
    }
}

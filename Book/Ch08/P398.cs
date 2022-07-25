using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P398
    {
        class Products
        {
            public int this[int i]
            {
                get { return i; }
                set { Console.WriteLine(i + "번째 상품 결정"); }
            }
        }
    }
}

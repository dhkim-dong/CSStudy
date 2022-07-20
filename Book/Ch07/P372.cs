using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P372
    {
        abstract class Parent    // abstract 키워드 자체가 이 메서드를 반드시 오버라이딩 해달라는 뜻이므로 virtual 키워드를 적지 않아도 된다. 반드시 override해라!
        {
            public abstract void Test();
        }

        class child : Parent
        {
            public override void Test()
            {
                
            }
        }
    }
}

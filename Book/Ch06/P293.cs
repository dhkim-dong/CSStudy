using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P293
    {
        class Box                 // 방어코드의 작성 필요성
        {
            public int width;
            public int height;

            public Box(int width, int heightint)
            {
                this.width = width;
                this.height = height;
            }

            public int Area()
            {
                return this.width * this.height;
            }
        }
    }
}

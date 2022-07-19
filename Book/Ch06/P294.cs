using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P294
    {
        class Box
        {
            private int width;
            private int height;

            public Box(int width, int height)
            {
                if(this.width >0 || height > 0) 
                {
                    this.width = width;
                    this.height = height;
                }
                else
                {
                    Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
                }             
            }
            public int Area()
            {
                return this.width * this.height;
            }
        }
    }
}

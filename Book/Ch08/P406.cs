using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P406
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main1(string[] args)  // 매개변수 없는 구조체는 기본값으로 초기화 된다.
        {
            Point point = new Point();
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}

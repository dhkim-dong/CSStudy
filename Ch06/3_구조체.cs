using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 날짜 : 2022/07/20
 * 이름 : 김동훈
 * 내용 : 구조체 실습하기 교재 P404
 * 
 * 구조체(Structure)
 *  - 간단하게 객체를 만들때 사용하는 구조형식
 *  - 클래스와 동일하지만 상속, 다형성 등 지원하지 않는다.
 */

namespace Ch06
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

        public int Add()
        {
            return x + y;
        }
    }

    internal class _3_구조체
    {
        static void Main(string[] args)
        {
            Point p1;                         // 구조체는 힙과 스택에 둘다 저장할 수 있다. new 키워드로 생성가능
            p1.x = 1;
            p1.y = 2;

            Console.WriteLine("p1 Add : "+ p1.Add());

            Point p2 = new Point(2,3);
            Console.WriteLine("p2 Add : "+ p2.Add());
        }
    }
}

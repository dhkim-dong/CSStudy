using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch12
{
    internal class P527
    {
        static void Main1(string[] args)
        {
            // 리스트안의 모든 값에 대해서 ( 일부 조건 값에 대해서) 그 값을 제곱한 값을 출력하고 싶다.. -> Linq 구문 사용하면 편하다.
            // 연습해야 할 점은.. Linq를 사용하기 전에 어떤 메소드로 구현할지도 알면 좋다.
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from n in input
                         select n * n;

            foreach(var n in output)
            {
                Console.WriteLine(n);
            }
        }
    }
}

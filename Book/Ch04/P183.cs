using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P183
    {
        static void Main33(string[] args)
        {
            Console.WriteLine("코드 4-27");
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' }); // 코드 해석 : 문자열을 데이터 받는 inputs 변수를 선언. 그곳에 문자열 input안의 변수를 Split()하여 리턴(문자열)된 값들을 넣는다.

            foreach (var item in inputs)
                Console.WriteLine(item);
        }
    }
}

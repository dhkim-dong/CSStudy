using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P182
    {
        static void Main32(string[] args)
        {
            Console.WriteLine("코드 4-26");
            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());  //  유니코드 상 소문자와 대문자 사이의 크기만큼 더해서 대소문자 변환시키는 방법.. upper = 대문자화
            Console.WriteLine(input);            //  클래스의 메서드로 자기자신을 변화시키지 않는 메서드 들을 비파죄적 메서드라 부른다.
        }
    }
}

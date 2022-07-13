using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P111
    {
        static void Main46(string[] args)
        {
            Console.WriteLine("코드 2-63");
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.1523"));
            Console.WriteLine(double.Parse("52.545"));

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("21856").GetType());
            Console.WriteLine(float.Parse("52.135").GetType());
            Console.WriteLine(double.Parse("52.57489").GetType());


            Console.WriteLine("코드 2-64");
            //Console.WriteLine(int.Parse("52.273"));  // 문자열 안의 데이터 형식과 다른 데이터의 값으로 Parse메소드를 돌리게되면 FormatException 예외 오류가 발생한다. 
            //Console.WriteLine(int.Parse("abc"));

        }
    }
}

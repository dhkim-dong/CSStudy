using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P96
    {
        static void Main33(string[] args)
        {
            Console.WriteLine("코드 2-44 증감 연산자 이해도 확인");
            int num = 10;
            Console.WriteLine(num++); //10
            Console.WriteLine(++num); //12
            Console.WriteLine(num--); //12 
            Console.WriteLine(--num); //10

            Console.WriteLine("코드 2-45 여러 줄로 나누어 적은 증감 연산자");

            int number = 10;
            Console.WriteLine(number);  //10
            number++; // 10
            number++; // 11
            Console.WriteLine(number); //12
            Console.WriteLine(number); //12
            number--; //12
            number--; //11
            Console.WriteLine(number); //10 

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    /*
     * 날짜 : 2022/07/12
     * 이름 : 김동훈
     * 내용 : C# 기본 입출력 실습하기 교재 p104
     * 
    */
    internal class _4
    {
        static void Main(string[] args)
        {
            // 이름 입력
            Console.Write("이름 입력 : ");
            string Name = Console.ReadLine();

            // 나이 입력
            Console.Write("나이 입력 : ");         // WriteLine : 출력후 커서를 한칸 내린다.
            string age = Console.ReadLine();

            // 주소 입력
            Console.Write("주소 입력 : ");
            string address = Console.ReadLine();

            Console.WriteLine("=========================");
            Console.WriteLine("이름 : "+Name);
            Console.WriteLine("나이 : "+age);
            Console.WriteLine("주소 : "+address);
        }
    }
}

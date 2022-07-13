using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    /*  
     *  날짜 : 2022/07/13
     *  이름 : 김동훈
     *  내용 : 조건문 Switch 실습하기 교재 p127
     */
    internal class _2_switch문
    {
        static void Main2(string[] args)
        {
            Console.Write("숫자 입력 : ");
            string strNum = Console.ReadLine();

            int num = int.Parse(strNum);

            switch (num % 2)
            {
                case 0:
                    Console.WriteLine($"{num}은 짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine(num + "은 홀수입니다.");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P136
    {
        static void Main6(string[] args)
        {
            double score = 3.6;
            if(score == 4.5)
                Console.WriteLine("신");
            else if(4.2 <= score && score < 4.5)
                Console.WriteLine("교수님의 사랑");

            // 범위를 일일이 나열해서 조건문을 따져 보는 방식
            // 하지만 조건문은 자동으로 앞선 조건을 거를 수 있다.

            if(score ==4.5)
                Console.WriteLine("신");
            else if(score >= 4.2)
                Console.WriteLine("교수님의 사랑");
            else if(score >= 3.5)
                Console.WriteLine("현 체제의 수호자");
            else if(score >= 2.8)
                Console.WriteLine("일반인");
            else if(score >= 2.3)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if(score >= 1.75)
                Console.WriteLine("오락문화의 선구자");
            else if(score >= 1.0)
                Console.WriteLine("불가촉천민");
            else if(score >= 0.5)
                Console.WriteLine("자벌레");
            else if(score > 0)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");
        }
    }
}

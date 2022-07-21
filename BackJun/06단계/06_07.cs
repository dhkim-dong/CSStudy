using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_07
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            // 같지 않은 세자리 수 두 수를 비교하는대..

            // 상수라는 놈은 A와 B를 거꾸로 읽고 수를 비교한다.

            // A   : [0][1][2] 4,7,5 ->  5,7,4 출력

            string reA = A[A.Length - 1].ToString()+ A[A.Length - 2].ToString() + A[0].ToString();
            string reB = B[B.Length - 1].ToString()+ B[B.Length - 2].ToString() + B[0].ToString();

            if(int.Parse(reA) > int.Parse(reB))
            {
                Console.WriteLine(int.Parse(reA));
            }
            else 
            {
                Console.WriteLine(int.Parse(reB));
            }

        }
    }
}

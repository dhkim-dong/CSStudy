using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._07단계
{
    internal class _7_3
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
        }

        static int SearchNum(int a)  // 내가 속한 그룹의 i와 i-1번째를 알 수 있다.  i란 (1,i) (i,1) 마지막 숫자
        {
            for (int i = 0; true; i++)
            {
                if(a <= i * (i + 1) / 2)
                {
                    return i;              // 몇번째 그룹이다.
                }
            }
        }
    }  
}

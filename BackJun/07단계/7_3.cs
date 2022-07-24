using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._07단계
{
    internal class _7_3
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            // N구역의 몇번째에 해당하는 값인가?
            int Xpos = 0;
            int Ypos = 0;
            int Num = SearchNum(N);

            if (Num % 2 == 0)
            {
                Xpos = N - (Num * (Num - 1) / 2);
                Ypos = Num + 1 - Xpos;
            }
            else
            {
                Ypos = N - (Num * (Num - 1) / 2);
                Xpos = Num + 1 - Ypos;
            }
            Console.WriteLine(Xpos.ToString() + "/" + Ypos.ToString()); 
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

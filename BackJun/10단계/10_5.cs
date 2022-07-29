using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._10단계
{
    internal class _10_5
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());


            // 해당 방식으로 풀면 무한히 많은 숫자를 values에 담아야 한다... 
            // 역순으로 가장 작은수 부터 찾는 로직을 만들어 보자

            int search = 666;
            int count = 0;

            while (true)
            {
                if (search.ToString().Contains("666"))
                {
                    count++;
                }

                if (N == count)
                    break;

                search++;
            }
            Console.WriteLine(search);
        }
    }
}

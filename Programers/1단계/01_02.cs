using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers._1단계
{
    // 약수 구하기

    internal class _01_02
    {
        public class Solution
        {
            static void Main(string[] args)
            {
                Console.WriteLine(solution(13, 17)); 
            }


            public static int solution(int left, int right)
            {
                int answer = 0;

                for (int i = left; i <= right; i++)
                {
                    if (Divisor(i) % 2 == 0)
                    {
                        answer += i;
                    }
                    else
                    {
                        answer -= i;
                    }
                }

                return answer;
            }

            public static int Divisor(int n)
            {
                int count = 0;
                int div = n;
                while(1 <= div) 
                {
                    if(n % div == 0)
                    {
                        count++;           
                    }
                    else
                    {
                    }
                    div--;
                }

                return count;
            }
        }
    }
}

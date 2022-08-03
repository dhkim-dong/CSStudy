using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers._1단계
{
    internal class _01_01
    {
        public class Solution
        {
            public bool solution(int x)
            {
                bool answer = false;

               if(x % (x % 10 + x/10 % 10 + x/100 %10 + x/1000 %10 + x/10000) == 0)
                {
                    answer = true;
                    return answer;
                }
                else
                {
                    answer = false;
                    return answer;
                }
            }
        }
    }
}

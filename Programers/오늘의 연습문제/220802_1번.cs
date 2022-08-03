using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers.오늘의_연습문제
{
    // report배열은 "[0] 앞의 사람이 [1] 뒤에 사람을 신고했음 으로 구성되어 있다.
    // 자신이 신고한 아이디가 몇명 신고되었는지 출력하는 함수이다.

    internal class _220802_1번
    {
        public class Solution
        {
            public int[] solution(string[] id_list, string[] report, int k)
            {
                int[] answer = new int[id_list.Length];
                for (int j = 0; j < id_list.Length; j++)
                {
                    int count = 0;
                    bool doubleReport = false;


                    for (int i = 0; i < report.Length; i++)
                    {                    
                        if (id_list[j] == report[i].Split()[1] && doubleReport == false)
                            count++;

                        if (report[j] == report[i])
                            doubleReport = true;
                    }
                    doubleReport = false;

                    if (count >= k)
                    {
                        answer[j] = count;
                    }
                    else
                    {
                        answer[j] = 0;
                    }            
                }
                return answer;
            }
        }
    }
}

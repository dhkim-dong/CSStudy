using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_03
    {
        static void Main3(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();

            int[] values = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                values[i] = (int)input[i];
            }

            // 아스키코드 a = 97   ~ z= 122   26개
            // 등장하는 위치를 출력하시오.

            int[] counts = new int[26];

            int[] Resultcount = new int[26];

            for (int i = 0; i < counts.Length; i++)
            {
                counts[i] = 97 + i;
            }

            for (int x = 0; x < input.Length; x++)
            {
                for (int n = 0; n < counts.Length; n++)
                {
                    if (values[x] == counts[n])
                    {
                        Resultcount[n]++;
                    }
                }
            }

            for (int y = 0; y < Resultcount.Length; y++)
            {
                sb.Append(Resultcount[y].ToString() + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

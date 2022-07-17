using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_03
    {
        static void Main3(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            string text = (a * b * c).ToString();

            //// 아스키 코드 '0' = 48   ~ 57 
            int[] result = new int[10];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 48 + i;
            }

            int[] resultCount = new int[10];

            for (int x = 0; x < text.Length; x++)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if ((int)text[x] == result[i])
                    {
                        resultCount[i]++;
                    }
                }
            }
            for (int i = 0; i < resultCount.Length; i++)
            {
                sb.Append(resultCount[i].ToString()+ "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

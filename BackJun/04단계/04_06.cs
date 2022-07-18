using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_06
    {
        static void Main6(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            string[] inputs = new string[T];
            for (int i = 0; i < T; i++)
            {
                inputs[i] = Console.ReadLine();
            }

            for (int i = 0; i < T; i++)
            {
                char[] temp = inputs[i].ToCharArray();
                int j = 0;
                int resultCount = 0;
                int Count = 0;

                while (true)
                {
                    if (temp[j].ToString() == "O")
                    {
                        Count++;
                        resultCount += Count;
                    }
                    else
                    {
                        Count = 0;
                    }
                    j++;

                    if (j == temp.Length)
                        break;
                }
                sb.Append(resultCount.ToString()+ "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

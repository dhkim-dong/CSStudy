using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._09단계
{
    internal class _9_4
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(isEmpty(i, j))
                    {
                        sb.Append(" ".ToString());
                        continue;
                    }
                    else
                    {
                        sb.Append("*".ToString());
                    }
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());

        }

        static bool isEmpty(int x, int y)
        {
            while (x!=0)
            {
                if (x % 3 == 1 && y % 3 == 1)
                    return true;

                x /= 3;
                y /= 3;
            }
            return false;
        }
       
    }
}

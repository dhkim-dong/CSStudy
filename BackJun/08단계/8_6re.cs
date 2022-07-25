using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._08단계
{
    internal class _8_6re
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            bool check = true;
            List<int> primelist = new List<int>();

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int front = n / 2;
                int back = n / 2;

                for(int j = 0; j < front; j++)
                {
                    if(CheckPrime(front) && CheckPrime(back))
                    {
                        sb.Append((front + " " + back).ToString());
                        break;
                    }
                    else
                    {
                        front--;
                        back++;
                    }
                }
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }


        static bool CheckPrime(int n)
        {
            bool check = true;
            for (int j = 2; j * j <= n; j++)
            {
                if (n % j == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._07단계
{
    internal class _7_6
    {
        static void Main1(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                int[,] arr = new int[15, 15];

                for (int x = 1; x <= n; x++)
                {
                    arr[0, x] = x;
                }

                for (int y = 1; y <= k; y++)
                {
                    arr[y, 1] = 1;
                }

                for (int r = 1; r <= k; r++)
                {
                    for (int t = 2; t <= n; t++)
                    {
                        arr[r, t] = arr[r - 1, t] + arr[r, t - 1];
                    }
                }
                Console.WriteLine(arr[k, n]);
            }
        }
    }
}

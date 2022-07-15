using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_03
    {
        static void Main3(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int tot =0;
            for (int i = 1; i <= input; i++)
            {
                tot += i;
            }
            Console.WriteLine(tot);
        }
    }
}

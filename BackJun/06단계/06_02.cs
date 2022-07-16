using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_02
    {
        static void Main2(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int input = int.Parse(Console.ReadLine());
            string value = Console.ReadLine();
            int tot = 0;
            for (int i = 0; i < input; i++)
            {
                 tot += int.Parse(value[i].ToString());
            }
             sb.Append(tot.ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_01
    {
        static void Main1(string[] args)
        {
            char input = Convert.ToChar(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            int result = (int)input;

            sb.Append(result.ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}

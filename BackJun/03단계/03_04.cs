using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_04
    {
        static void Main4(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                sb.Append( (a + b).ToString() + "\n");                   
            }
            Console.WriteLine(sb.ToString()); 
        }
    }
}

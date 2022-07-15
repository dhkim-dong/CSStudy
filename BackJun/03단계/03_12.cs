using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._03단계
{
    internal class _03_12
    {
        static void Main12(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split();
                StringBuilder sb = new StringBuilder();
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                if (a == 0 && b == 0)
                    break;

                sb.Append((a + b).ToString());
                Console.WriteLine(sb.ToString()); 
                sb.Clear();
            }
        }
    }
}

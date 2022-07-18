using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_02
    {
        static void Main2(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            int a5 = int.Parse(Console.ReadLine());
            int a6 = int.Parse(Console.ReadLine());
            int a7 = int.Parse(Console.ReadLine());
            int a8 = int.Parse(Console.ReadLine());
            int a9 = int.Parse(Console.ReadLine());

            int[] values = { a1, a2, a3, a4, a5, a6, a7, a8, a9 };

            int maxvalue = values.Max();
            int maxappendix = Array.IndexOf(values, maxvalue);
            sb.Append(values.Max().ToString());
            Console.WriteLine(sb.ToString());
            sb.Clear();
            sb.Append((maxappendix + 1).ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}

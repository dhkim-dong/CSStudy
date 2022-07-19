using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_03
    {
        static void Main3(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();


            for (int j = 97; j < 123; j++)
            {
                char alpha = Convert.ToChar(j);
                bool hasinput = false;
                bool isFirst = false;

                for (int i = 0; i < input.Length; i++)
                {
                    if(input[i] == alpha && !isFirst)
                    {
                        isFirst = true;
                        hasinput = true;
                        sb.Append(i.ToString() + " ");
                    }
                }

                if (!hasinput)
                {
                    sb.Append("-1" + " ");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

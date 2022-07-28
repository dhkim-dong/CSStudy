using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._10단계
{
    internal class _10_4
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int count = 0;

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();

                for (int x = 0; x < input.Length; x++)
                {
                    if (input[0] == 'W')
                    {
                        if (x % 2 == 0 && input[x] != 'W')
                        {
                            count++;
                        }
                        else if (x+1 > input.Length)
                        {
                            continue;
                        }
                        else if (x % 2 != 0 && input[x + 1] != 'B')
                            count++;
                    }
                    else if (input[0] == 'B')
                    {
                        if (x % 2 == 0 && input[x] != 'B')
                        {
                            count++;
                        }
                        else if (x + 1 > input.Length)
                        {
                            continue;
                        }
                        else if (x % 2 != 0 && input[x + 1] != 'W')
                            count++;
                    }
                    
                }            
            }

            Console.WriteLine(count);
        }
    }
}

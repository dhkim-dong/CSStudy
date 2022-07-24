using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._07단계
{
    internal class _7_5
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());


            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                int H = int.Parse(inputs[0]);
                int W = int.Parse(inputs[1]);
                int N = int.Parse(inputs[2]);

                int front = N % H;
                int back = (int)Math.Ceiling((double)N / (double)H);

                if(front == 0)
                {
                    front = H;
                }

                if(H == 1)
                {
                    if(back < 10)
                    {
                        Console.WriteLine("10" + back.ToString());
                        continue;
                    }
                    
                    else
                    {
                        Console.WriteLine("1" + back.ToString());
                        continue;
                    }
                }

                if(back == 1)
                {
                    Console.WriteLine(N.ToString() + "01");
                }
                else if(back >= 10)
                {
                    Console.WriteLine(front.ToString() + back.ToString());
                }
                else
                {
                    Console.WriteLine(front.ToString() + "0" + back.ToString());
                }
            }
        }
    }
}

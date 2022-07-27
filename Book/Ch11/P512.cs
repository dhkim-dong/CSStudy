using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch11
{
    internal class P512
    {
        static void Main1(string[] args)
        {
            Thread threadA = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("A");
                }
            });

            Thread threadB = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("B");
                }
            });

            Thread threadC = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("C");
                }
            });

            threadA.Start();
            threadB.Start();
            threadC.Start();
        }
    }
}

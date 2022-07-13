using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P169
    {
        static void Main23(string[] args)
        {
            Console.WriteLine("코드 4-15");
            long start = DateTime.Now.Ticks;
            long count = 0;

            while(start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복했습니다.");
        }
    }
}

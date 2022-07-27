using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch12
{
    internal class P529
    {
        static void Main1(string[] args)
        {
            // linq 조건을 줄이는 것도 편하지만, 오름차순 또는 내림차순 정렬이 너무 편하다.
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from n in input
                         where n >= 5 && n % 2 == 0
                         orderby n descending
                         select n;

            foreach(var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}

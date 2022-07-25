using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P399
    {
        class SquareCalculator
        {
            public int this[int i]
            {
                get { return i * i; }
            }
        }

        static void Main1(string[] args)
        {
            SquareCalculator square = new SquareCalculator();
            Console.WriteLine(square[10]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch10
{
    internal class P480
    {
        static void Main1(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch(Exception e)
            {
                Console.WriteLine("예외가 발생했습니다.");
            }
        }
    }
}

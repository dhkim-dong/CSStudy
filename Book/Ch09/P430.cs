using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class P430
    {
        class Dummy : IDisposable      // using 블록 기능을 사용할 때 자동으로 호출되는 기능이다.
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose() 메서드를 호출합니다.");
            }
        }

        static void Main1(string[] args)
        {
            using (Dummy dummy = new Dummy())
            {

            }
        }
    }
}

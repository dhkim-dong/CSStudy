using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P101
    {
        //var global = 52; // 외부에서 사용시 에러가 발생한다.
        static void Main37(string[] args)
        {
            Console.WriteLine("코드 2-49 var 키워드의 제약");
            var number = 10.2;
            //number = "변경"; 에러 발생

            var local = 273;


        }
    }
}

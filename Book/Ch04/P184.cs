using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P184
    {
        static void Main34(string[] args)
        {
            //string class에 포함된 Trim 메서드 
            //Trim()      : 양옆의 공백제거
            //TrimStart() :   앞의 공백제거
            //TrimEnd()   :   뒤의 공백제거


            Console.WriteLine("코드 4-28");
            string input = "test       \n";
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class P446
    {
        static void Main1(string[] args)
        {
            //File.WriteAllText(@"c:\test\test.txt", "문자열을 파일에 씁니다");


            using (StreamReader reader = new StreamReader(@"c:\test\test.txt"))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

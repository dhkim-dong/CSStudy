using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{


    internal class P442 
    {
        static void Main1(string[] args)
        {
            //File.WriteAllText(@"c:\test\test.txt", "문자열을 파일에 씁니다");


            using (StreamWriter sw = new StreamWriter(@"c:\test\test.txt"))
            {
                sw.WriteLine("안녕하세요");
                sw.WriteLine("StreamWriter 클래스를 사용해");
                sw.WriteLine("글자를 여러 줄 입력해봅니다");

                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine("반복문 - " + i);
                }
            }
            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));
        }
    }
}

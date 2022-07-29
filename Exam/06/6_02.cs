using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    internal class _6_02
    {
        static void Main1(string[] args)
        {
            string path = "C:\\Users\\502\\Desktop\\Gugudan.txt";

            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                for (int x = 2; x <= 9; x++)
                {
                    sw.WriteLine($"{x}단");
                    for (int y = 1; y <= 9; y++)
                    {
                        sw.Write($"{x} * {y} = {x*y}");
                        sw.WriteLine();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }

            Console.WriteLine("구구단 파일 생성 완료...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P234
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("코드 5-20");
            List<Student> list = new List<Student>();
            {
                new Student() { name = "윤인성", grade = 1 };
                new Student() { name = "연하진", grade = 2 };
                new Student() { name = "윤아린", grade = 3 };
                new Student() { name = "윤명월", grade = 4 };
                new Student() { name = "구지연", grade = 1 };
                new Student() { name = "김연화", grade = 2 };
            }
        }
    }
}

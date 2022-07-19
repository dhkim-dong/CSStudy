using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P236
    {
        class Student
        {
            public string name;
            public int grade;
        }

        static void Main1(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "연하진", grade = 2 });
            list.Add(new Student() { name = "윤아린", grade = 3 });
            list.Add(new Student() { name = "윤명월", grade = 4 });
            list.Add(new Student() { name = "구지연", grade = 1 });
            list.Add(new Student() { name = "김연회", grade = 2 });

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }
            // remove로 원소를 제거해서 인덱스가 밀려 결과값이 다르게 나타난다. for반복문을 이용한 remove이용시의 문제점

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }

        }
    }
}

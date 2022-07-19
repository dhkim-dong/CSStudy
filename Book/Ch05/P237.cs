﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P237
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

            for (int i = list.Count - 1; i >= 0 ; i--)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }
            // List에서 원소를 지우기 위해서는 역 반복문을 사용해서 제거해야 한다.

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }

        }
    }
}

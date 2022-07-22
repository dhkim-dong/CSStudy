using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    class MyIndexer<T>  // 클래스를 배열처럼 사용하는 C#만이 갖고 있는 문법
    {
        private T[] array = new T[10];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }

    internal class _04_06
    {
        static void Main1(string[] args)
        {
            var myIndexer = new MyIndexer<string>();

            myIndexer[0] = "Hello, Wolrd!";
            myIndexer[1] = "Hello, Korea!";
            myIndexer[2] = "Hello, Busan!";
            myIndexer[3] = "Hello, C#!";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(myIndexer[i]);
            }

        }
    }
}

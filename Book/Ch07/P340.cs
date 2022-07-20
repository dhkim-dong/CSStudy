using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P340
    {
        static void Main1(string[] args)
        {
            List<Dog> Dogs = new List<Dog>();
            List<Cat> Cats = new List<Cat>();

            foreach(var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach(var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P346
    {
        static void Main1(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
           {
             new Dog(), new Cat()
           };
        foreach(var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if(item is Dog)
                {
                    // item을 형변화 해야 사용할 수 있는대, 어떤 방법이 있을까?
                }
                if(item is Cat)
                {

                }
            }
        }
    }
}

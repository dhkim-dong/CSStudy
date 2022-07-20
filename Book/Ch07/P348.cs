using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P348
    {
        static void Main1(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
           {
             new Dog(), new Cat()
           };
            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if (item is Dog)
                {
                    ((Dog)item).Bark();
                }
                if (item is Cat)
                {
                    (item as Cat).Meow(); // 이 경우에는 이미 item을 Cat타입으로 조건을 확정시켰기 때문에 as를 사용하지 않아도 된다. as는 어떨 경우에 유용할까?
                }
            }
        }
    }
}

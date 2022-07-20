using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P350
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

                var dog = item as Dog; // 새로운 참조변수에 Dog로 형변환한 어떤 클래스 타입을 저장한다. as는 null값도 반환하기 때문에 조건문을 활용해서 형변환을 사용할 수 있다.
                if(dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if(cat != null) { cat.Meow(); }
            }
        }
    }
}

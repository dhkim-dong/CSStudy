using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P343
    {
        static void Main1(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                    new Dog(), new Cat(), new Dog(), new Dog()
            };

            // 자식 Dog, Cat이 섞여있다.. Dog, Cat의 기능을 사용하고 싶은대 어떻게 할까?
            // (1) 강제 형변환 casting을 써보자

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                //((Cat)item).Meow(); // 에러 발생 -> Dog형식을 Cat으로 변환할 수 없습니다...
            }
        }
    }
}

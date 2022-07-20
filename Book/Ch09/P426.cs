using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class P426
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()    // Object의 virtual을 구현함
            {
                return Name + " : " + Price + "원";
            }
        }

        static void Main1(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product(){Name = "고구마", Price = 1500},
                new Product(){Name = "사과", Price = 2400},
                new Product(){Name = "바나나", Price = 1000},
                new Product(){Name = "배", Price = 3000},
            };
            list.Sort();  // 에러가 발생한다. 어떤 방식으로 정렬해야 하는지 모르기 때문이다.

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

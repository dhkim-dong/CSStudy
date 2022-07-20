using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class P427
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object? obj)
            {
                return this.Price.CompareTo((obj as Product).Price);
            }

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
            list.Sort();  // Product가 IComparable을 구현하였기 때문에 비교 연산자 Sort를 사용할 수 있게 되었다!  EX) IEnumator -> 

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

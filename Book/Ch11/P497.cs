using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch11
{
    internal class P497
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        static void Main1(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product(){Name = "감자", Price = 500},
                new Product(){Name = "사과", Price = 700},
                new Product(){Name = "고구마", Price = 400},
                new Product(){Name = "배추", Price = 600},
                new Product(){Name = "상추", Price = 300},
            };

            product.Sort(SortWithPrice);

            foreach(var item in product)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }
        }

        static int SortWithPrice(Product a , Product b)
        {
            return a.Price.CompareTo(b.Price);
        }
    }
}

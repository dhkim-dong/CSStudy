using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P227
    {
        static void Main9(string[] args)
        {
            Product product = new Product();

            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name + " : " + product.price + "원");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._15단계
{
    internal class _15_02
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int[] arr2 = Array.ConvertAll(inputs, s => int.Parse(s));

            Array.Sort(arr2);

            if (n == 1) // 약수가 하나밖에 없다면 (즉 약수가 2일 때 는 4!)
            {
                Console.WriteLine(arr2[0] * arr2[0]);
            }
            else // 나머지는 가장 큰 약수 x 가장 작은 약수 = 진 약수가 된다.
            {
                Console.WriteLine(arr2[n-1] * arr2[0]);
            }

        }
    }
}

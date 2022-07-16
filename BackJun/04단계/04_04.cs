using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._04단계
{
    internal class _04_04
    {
        static void Main4(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine( ));
            int a2 = int.Parse(Console.ReadLine( ));
            int a3 = int.Parse(Console.ReadLine( ));
            int a4 = int.Parse(Console.ReadLine( ));
            int a5 = int.Parse(Console.ReadLine( ));
            int a6 = int.Parse(Console.ReadLine( ));
            int a7 = int.Parse(Console.ReadLine( ));
            int a8 = int.Parse(Console.ReadLine( ));
            int a9 = int.Parse(Console.ReadLine( ));
            int a10 = int.Parse(Console.ReadLine( ));

            int[] inputs = { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 };

            int[] array = new int[10];
            int count = 0 ;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = inputs[i] % 42;
            }

            for (int i = 0; i < array.Length; i++)
            {
                string Number0 = array[i].ToString();
                for (int j = 1; j < array.Length; j++)
                {
                    string Number2 = array[j].ToString();

                    if(Number0 == Number2)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(array.Length - count);

            // 입력 값 1부터 10을 42로 나눈 나머지가 다른 것이 몇 개 있는가?

        }
    }
}

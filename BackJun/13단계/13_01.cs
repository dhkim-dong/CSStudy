using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._13단계
{
    class _13_01
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int w = int.Parse(inputs[2]);
            int h = int.Parse(inputs[3]);

            int resultx1;
            int resultx2;
            int resulty1;
            int resulty2;

            //  x의 좌측 우측값 y의 위측 아래측 값 중 최소값을 출력하라

            resultx1 = x;
            resultx2 = w - x;
            resulty1 = y;
            resulty2 = h - y;

            List<int> list = new List<int>();

            list.Add(resultx1);
            list.Add(resultx2);
            list.Add(resulty1);
            list.Add(resulty2);

            Console.WriteLine(list.Min());
           
        }
    }
}

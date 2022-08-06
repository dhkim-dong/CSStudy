using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._13단계
{
    internal class _13_02
    {
        // 3개의 점을 주고 평행한 직사각형을 만들기 위한 4번째 x,y를 구하시오

        static void Main1(string[] args)
        {
            string[] s1 = Console.ReadLine().Split();
            string[] s2 = Console.ReadLine().Split();
            string[] s3 = Console.ReadLine().Split();

            int x1 = int.Parse(s1[0]);
            int y1 = int.Parse(s1[1]);

            int x2 = int.Parse(s2[0]);
            int y2 = int.Parse(s2[1]);

            int x3 = int.Parse(s3[0]);
            int y3 = int.Parse(s3[1]);

            List<int> listx = new List<int>();
            List<int> listy = new List<int>();

            listx.Add(x1);
            listx.Add(x2);
            listx.Add(x3);
            listx.Sort();

            listy.Add(y1);
            listy.Add(y2);
            listy.Add(y3);
            listy.Sort();

            x1 = listx[0];
            x2 = listx[1];
            x3 = listx[2];

            y1 = listy[0];
            y2 = listy[1];
            y3 = listy[2];

            int resultx = x1 - x2 + x3;
            int resulty = y1 - y2 + y3;

            Console.WriteLine($"{resultx} {resulty}");

        }
    }
}

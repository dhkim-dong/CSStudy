using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_06
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<(int,int)> list = new List<(int,int)>();
            StringBuilder sb = new StringBuilder();

            // x를 정렬시킨 후 y값을 정렬시키고 싶다.
            // x가 같아도 y가 같은 값은 없다.
            // 튜플을 사용하면 하나의 메서드로 2개의 값(x와 y값을 출력할 수 있다.)
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);

                list.Add((x,y));
            }

            var output = list.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToList();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{output[i].Item1} {output[i].Item2}");    
            }
        }
    }
}

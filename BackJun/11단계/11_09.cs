using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_09
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());

            List<(int,int,string)> list = new List<(int,int,string)> ();
            // 나이순
            // 가입한 순서
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                int age = int.Parse(inputs[0]);
                int log = i;
                string name = inputs[1];
                
                list.Add((age,log,name));
            }

            var output = list.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();


            for (int i = 0; i < N; i++)
            {
                sb.Append(output[i].Item1 + " " + output[i].Item3 + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}

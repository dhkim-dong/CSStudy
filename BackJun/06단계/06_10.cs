using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_10
    {
        static void Main1(string[] args)
        {
            // 그룹 단어
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    char[] arr = new char[input.Length];
                    bool check = false;
                    bool isGroup = false;

                    for (int x = 1; x < input.Length; x++)
                    {
                        if (input[x-1] == input[x])
                        {
                            continue;
                        }
                        else if(check == true)
                        {
                            for (int y = 0; y < x-1; y++)
                            {
                                if (input[x] == input[y])
                                {
                                    isGroup = true;
                                    break;
                                } 
                            }
                        }
                        else
                        {
                            check = true;
                        }
                    }
                    if (isGroup)
                    {
                        count++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(N - count);
        }
    }
}

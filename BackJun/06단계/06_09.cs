using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_09
    {
        static void Main1(string[] args)
        {
            string input = Console.ReadLine();

            // 문자열의 원소를 뽑아와서 크로아티아 알파벳인지 출력하는 함수를 만든다.

            int cratiacount = 0;

            for (int i = 0; i < input.Length; i++)       //  크로아티아 알파벳을 구한다. 
            {
                if (i + 1 < input.Length)
                {
                    if (input[i] == 'c') // i=0 일때 (조합) ok // i=1의 원소..에 대해서 처리방법을 생각해야한다. lj , dz, nj 같은 것
                    {
                        if (input[i + 1] == '=')
                            cratiacount++;
                    }
                    else if (input[i] == 'c')
                    {
                        if (input[i + 1] == '-')
                            cratiacount++;
                    }
                    else if (input[i] == 'd')
                    {
                        if (input[i + 1] == '-')
                            cratiacount++;

                        if (i + 2 < input.Length)
                        {
                            if (input[i + 1] == 'z' && (input[i + 2] == '='))
                            {
                                cratiacount += 2;
                            }
                        }
                    }
                    else if (input[i] == 'l')
                    {
                        if (input[i + 1] == 'j')
                            cratiacount++;
                    }
                    else if (input[i] == 'n')
                    {
                        if (input[i + 1] == 'j')
                            cratiacount++;
                    }
                    else if (input[i] == 's')
                    {
                        if (input[i + 1] == '=')
                            cratiacount++;
                    }
                    else if (input[i] == 'z')
                    {
                        if (input[i - 1] == 'd' && input[i + 1] == '=')
                        {
                            continue;
                        }
                        if (input[i + 1] == '=')
                            cratiacount++;
                    }
                }           
            }
            // input의 length 값에서 크로아티아 알파벳의 숫자를 빼면 정답이 출력!
            // dz=이 나올경우 z=은 빼야한다..

            Console.WriteLine(input.Length - cratiacount);

        }
    }
}

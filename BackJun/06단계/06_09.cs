using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._06단계
{
    internal class _06_09
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // 문자열의 원소를 뽑아와서 크로아티아 알파벳인지 출력하는 함수를 만든다.

            int cratiacount = 0;

            for (int i = 0; i < input.Length; i++)       //  length Exception을 해결하기 위해서는 -> i행을 먼저 조사한 후에 i+1을 조사한다.
            {             



                if (input[i] == 'c' ) // i=0 일때 (조합) ok // i=1의 원소..에 대해서 처리방법을 생각해야한다. lj , dz, nj 같은 것
                {
                    if (input[i+1] == '=')
                        cratiacount++;
                }
                else if (input[i].ToString() + input[i + 1].ToString() == "c-")
                {
                    count++;
                    isAlpha = true;
                }
                else if (input[i].ToString() + input[i + 1].ToString() + input[i+2] == "dz=" && !notBeta)  // 예외 사항을 만들어 둘 것 (i) 인덱스 초과하는 경우
                {
                    count++;
                    isAlpha = true;
                    isBeta = true;
                }
                else if (input[i].ToString() + input[i + 1].ToString() == "d-")
                {
                    count++;
                    isAlpha = true;
                }
                else if (input[i].ToString() + input[i + 1].ToString() == "lj")  
                {
                    count++;
                    isAlpha = true;
                }
                else if (input[i].ToString() + input[i + 1].ToString() == "nj")
                {
                    count++;
                    isAlpha = true;
                }
                else if (input[i].ToString() + input[i + 1].ToString() == "s=")
                {
                    count++;
                    isAlpha = true;
                }
                else if (input[i].ToString() + input[i + 1].ToString() == "z=")
                {
                    count++;
                    isAlpha = true;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

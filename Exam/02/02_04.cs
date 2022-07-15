using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{
    internal class _02_04
    {
        static void Main4(string[] args)
        { 
            int[] arr = { 4, 2, 1, 5, 3 };            // 배열 정렬하기. 선택정렬(첫번째 원소를 다른 모든 원소와 비교해서 자리를 바꾼다. 두번째 부터.. n-1번째까지 반복한다)
                                                      // Big-o : n*n 
            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            foreach(int n in arr)
            {
                Console.Write(n + ", ");
            }
        }
    }
}

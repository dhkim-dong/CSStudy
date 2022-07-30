using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._11단계
{
    internal class _11_02
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int value = int.Parse(Console.ReadLine());
                list.Add(value);
            }
            // sort정렬로는 시간초과
            //list.Sort();
            // 이진탐색을 활용한 정렬법
            MergeSort(list, 0, N / 2, N);

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void MergeSort(List<int> list, int begin, int mid, int end)
        {
            int[] lowHalf = new int[mid + 1];
            int[] highHalf = new int[end - mid];

            int k = begin;
            int i = 0;
            int j = 0;

            for (i = 0; k <= mid; i++,k++)
            {
                lowHalf[i] = list[k];
            }

            for (j = 0; k < end; j++,k++)
            {
                highHalf[j] = list[k];
            }

            k = begin;
            i = 0;
            j = 0;

            while(i < lowHalf.Length && j < lowHalf.Length)
            {
                if (lowHalf[i] < highHalf[j])
                {
                    list[k] = lowHalf[i];
                    i++;
                }
                else
                {
                    list[k] = highHalf[j];
                    j++;
                }
                k++;
            }
            while(i < lowHalf.Length)
            {
                list[k] = lowHalf[i];
                i++; k++;
            }
            while(j < highHalf.Length)
            {
                list[k] = highHalf[j];
                j++; k++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *  
 * 데이터의 크기가 클때 ~10억 // 데이터의 범위는 작지만 
 * 카운트 솔팅 (Count Sorting Array)을 사용해보자
 * 카운트 솔팅 : 정수를 값으로 갖는 배열에서 데이터의 등장한 횟수를 저장하여 이 데이터를 정렬하는 알고리즘
 * 
 */


namespace BackJun._12단계
{
    internal class _12_4
    {
        static void Main1(string[] args)
        {
            int N = int.Parse(Console.ReadLine());


            int[] arr = new int[20000001]; // 카운트 솔팅을 위한 배열 선언 

            string[] strN = Console.ReadLine().Split();

            int M = int.Parse(Console.ReadLine());

            string[] strM = Console.ReadLine().Split();

            int nIdx = 10000000;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < strN.Length; i++)
            {
                arr[nIdx + int.Parse(strN[i])]++;
            }
            for (int i = 0; i < strM.Length; i++)
            {
                sb.Append(arr[nIdx + int.Parse(strM[i])] + " ");
            }
            Console.WriteLine(sb);
        }
    }
}

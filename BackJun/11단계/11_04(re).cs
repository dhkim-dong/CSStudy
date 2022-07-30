using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 최빈값을 빠르게 구하기   
 * (1) list를 만들어서 인덱스가 다르고 값이 같을 때마다 int++해준 count를 저장하는 Count 배열을 만들었다. => 모든 List값을 항상 검사하기 때문에 시간이 오래걸린다.
 * (2) 문제에서 최빈값의 2번째 까지만 검색하면 되는 조건을 이용한다.
 * 배열의 값들을 그룹화(집합)하여 Key로 값을 item.Count로 그 숫자를 확인할 수 있다. 배열.GroupBy메서드활용
 * arr.GroupBy(x=>x)의 의미? 람다식 표현 x => x 매개변수 x를 사용해서 x를 return한다.
 * bool 값을 활용해서 처음 최빈값을 찾았을때 bool을 check하고 이후에 같은 최빈값이 발견되면서 bool check인 경우만 확인하여 속도를 향상시켰다.
 * 결론 : 시간초과가 발생하는 경우는 자료형의 모든 데이터를 검색하는 case인 경우가 대부분이다.
 * 따라서 시간을 절약하기 위해서 특정 자료형만 search할 수 있는 필드를 선언하여 data를 가공하는 알고리즘을 만드는 연습을 해야한다.
 * 추가적으로 시간절약도가 적은 Sort(정렬) 알고리즘에 대해서 공부하는 것도 도움이 될 것 같다.
 */

namespace BackJun._11단계
{
    internal class _11_04_re_
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int data = 0;
            int data_Count = 0;
            bool flag = false;


            // 반복된 값은 Key로 반복된 횟수는 count에 저장
            foreach(var item in arr.GroupBy(x=>x))
            {
                if (item.Count() < data_Count)
                    continue;

                if(item.Count() > data_Count)
                {
                    data_Count = item.Count();
                    data = item.Key;
                    flag = false;
                    continue;
                }

                // 반복된 값은 flag를 통해서 두번째 까지만 search하고 다음 반복문으로 넘어간다.
                // 3번째 중복값은 검색하지 않기 때문에 시간이 절약된다.
                if(data_Count == item.Count() && flag == false)
                {
                    data = item.Key;
                    flag = true;
                    continue;
                }
            }

            sb.Append((int)Math.Round(arr.Average()) + "\n");
            sb.Append(arr[N / 2] + "\n");
            sb.Append(data + "\n");
            sb.Append(arr.Max() - arr.Min());

            Console.WriteLine(sb);
        }
    }
}

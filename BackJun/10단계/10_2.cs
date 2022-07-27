using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJun._10단계
{
    internal class _10_2
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string N = Console.ReadLine();
            Console.WriteLine(generator(int.Parse(N))); 

        }
        
        // 무한 반복으로 전체 값을 찾는 로직 => 시간초과 1부터~N까지 전부다 조사하기 때문에 시간이 n
        //static int Publisher(int pub)
        //{
        //    for(int N = 1; true; N++)
        //    {
        //        if (pub == N + N % 10 + N / 10 % 10 + N / 100 % 10 + N / 1000 % 10 + N / 10000 % 10 + N / 100000 % 10 + N / 1000000 % 10)
        //            return N;
        //    }
        //}

        // 분해합을 구하는 함수
        static int Publisher(string N)
        {
            List<int> value = new List<int>();

            for (int i = 0; i < N.Length; i++)
            {
                value.Add(int.Parse(N[i].ToString()));
            }
            int result = 0;

            foreach(var i in value)
            {
                result += i;
            }

            result += int.Parse(N);

            return result;
        }

        // 생성자를 구하는 함수
        static int generator(int num)
        {
            int temp = num - 1;             // 주어진 값보다 작은 값들을 temp에 저장한다. (정수값이기 때문에 1씩 감소)
            int ans = num;                  // 현재값을 저장하는 변수
            while(temp > 0)                 // temp값이 0이되면 종료한다.
            {
                if(Publisher(temp.ToString()) == num)           
                {
                    if (ans > temp) ans = temp;
                }
                temp--;
            }
            if (ans == num) return 0;       // 분해합 결과 값이 변함이 없으면 0을 반환한다.
            else return ans;                // 결과가 있다면 그 ans값을 반환한다.
        }

        // 시간 복합도가 얼마나 빠른지 알고 싶다.
    }
}

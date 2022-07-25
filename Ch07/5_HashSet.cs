using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/25
 * 이름 : 김동훈
 * 내용 : 컬렉션 집합 실습하기
 * 
 * 집합(HashSet)
 *  - 키값(Key- Value) 쌍으로 이루어진 자료구조
 *  - HashTable을 일반화 시켜 더 나은 성능을 제공
 *  - List와 더불어 가장 많이 사용하는 자료구조
 */

namespace Ch07
{
    internal class _5_HashSet
    {
        static void Main(string[] args)
        {
            // 집합 생성
            HashSet<int> set = new HashSet<int>();

            //데이터 입력
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(2);
            set.Add(3);

            //데이터 출력
            Console.WriteLine("집합 갯수 : " + set.Count);

            foreach(int i in set)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 집합 연산
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int>() { 2, 3, 5, 6, 7 };

            var result1 = set1.Intersect(set2); // 교집합
            var result2 = set1.Union(set2); // 합집합
            var result3 = set1.Except(set2); // set1에서 set2의 교집합을 빼라 (차집합)

            foreach(int i in result1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (int i in result2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (int i in result3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}

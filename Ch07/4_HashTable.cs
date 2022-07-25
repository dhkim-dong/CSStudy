using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/25
 * 이름 : 김동훈
 * 내용 : 컬렉션 딕셔너리 실습하기
 * 
 * 딕셔너리(Dictionary)
 *  - 키값(Key- Value) 쌍으로 이루어진 자료구조
 *  - HashTable을 일반화 시켜 더 나은 성능을 제공
 *  - List와 더불어 가장 많이 사용하는 자료구조
 */

namespace Ch07
{
    internal class _4_HashTable
    {
        static void Main1(string[] args)
        {
            /////////////HashTable
            // 테이블 생성
            Hashtable table = new Hashtable();

            // 데이터 추가

            table['A'] = "Apple";
            table.Add('b', "Banana");
            table.Add('c', "Cherry");

            // 데이터 삭제
            table.Remove('c');

            foreach (var item in table.Values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            /////////////Dictionary
            // 딕셔너리 생성
            Dictionary<char, string> dic = new Dictionary<char, string>();

            // 데이터 추가
            dic['A'] = "Apple";
            dic.Add('b', "Banana");
            dic.Add('c', "Cherry");

            // 데이터 삭제
            dic.Remove('b');
            foreach(string fruit in dic.Values)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // 딕셔너리 연습I
            Dictionary<int, string> people = new Dictionary<int, string>();

            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            foreach(int k in people.Keys)
            {
                Console.Write($"K : {k}, V : {people[k]}" + " ");
            }
            Console.WriteLine();
            // 딕셔너리 연습II
            Dictionary<int, Apple> d1 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d2 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d3 = new Dictionary<int, Apple>();

            d1.Add(101, new Apple("한국", 3000));
            d1.Add(102, new Apple("미국", 2000));
            d1.Add(103, new Apple("일본", 1000));

            d2.Add(201, new Apple("중국", 3000));
            d2.Add(202, new Apple("대만", 2000));
            d2.Add(203, new Apple("홍콩", 1000));

            d3.Add(301, new Apple("호주", 3000));
            d3.Add(302, new Apple("영국", 2000));
            d3.Add(303, new Apple("인도", 1000));

            List<Dictionary<int, Apple>> apples = new List<Dictionary<int, Apple>>();
            apples.Add(d1);
            apples.Add(d2);
            apples.Add(d3);

            //한국 사과 출력
            Dictionary<int, Apple> dicApple = apples[0];
            Apple korApple = dicApple[101];
            korApple.Show();

            // 미국 사과
            apples[0][102].Show();

            // 대만 사과
            apples[1][202].Show();

            // 인도 사과
            apples[2][303].Show();
        }
    }
}

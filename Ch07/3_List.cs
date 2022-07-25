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
 * 내용 : 컬렉션 리스트 실습하기
 * 
 * 리스트(List)
 *  - 배열과 유사한 선형자료구조로 배열과 다르게 동적으로 데이터를 처리
 *  - ArrayList를 일반화 시켜 더 나은 성능을 가진 List를 사용
 */


namespace Ch07
{
    internal class _3_List
    {
        static void Main1(string[] args)
        {
            ////////////////////////////ArrayList
            //생성
            ArrayList arrlist1 = new ArrayList();
            //데이터 추가
            arrlist1.Add(1);
            arrlist1.Add("김유신");
            arrlist1.Add(true);

            //데이터 삽입   : Insert 이후의 번호가 밀린다.
            arrlist1.Insert(1, 6);


            //데이터 삭제
            arrlist1.Remove(6);   // 데이터(Value) 6을 삭제
            arrlist1.RemoveAt(0); // 번호(index)로 데이터 삭제

            foreach (var i in arrlist1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // 다양한 타입의 데이터를 갖는 ArrayList
            ArrayList arrList2 = new ArrayList();
            arrList2.Add(1);
            arrList2.Add(1.23);
            arrList2.Add(true);
            arrList2.Add('a');
            arrList2.Add("Apple");

            foreach(var i in arrList2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            ////////////////////////////List
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            list1.Insert(1, 6);

            list1.Remove(4);
            list1.RemoveAt(1);
            foreach(int i in list1) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List<string> list2 = new List<string>();
            list2.Add("서울");
            list2.Add("대전");
            list2.Add("대구");
            list2.Add("부산");
            list2.Add("광주");

            foreach (var item in list2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            List<Apple> list3 = new List<Apple>();

            list3.Add(new Apple("한국", 3000));
            list3.Add(new Apple("미국", 2000));
            list3.Add(new Apple("일본", 1000));

             Apple apple = list3[0];
             apple.Show();

            list3[1].Show();
            list3[2].Show();
        }
    }
}

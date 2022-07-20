using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P345
    {
        static void Main1(string[] args)
        {
            // 최상의 클래스인 Object는 모든 객체타입을 list에 담을 수 있다.
            List<Object> listOfObject = new List<Object>();
            listOfObject.Add(new Dog());
            listOfObject.Add(new Cat());
            listOfObject.Add(52);
            listOfObject.Add(52l);
            listOfObject.Add(52.23f);
            listOfObject.Add(52.238);

            // 박싱 , 언박싱

            // 성능에 부하를 주기 때문에 사용할 타입을 일반화 할 필요성이 있다!
        }
    }
}

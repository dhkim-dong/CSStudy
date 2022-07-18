using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Account
    {
        //속성 : private 선언으로 캡슐화
        private string bank;
        private string id;
        private string name;
        private int balance;

        // 빠른 생성자 생성 방법 : 리팩토링 (ctrl + . )
        // 생성자 : 캡슐화된 속성을 초기화하기 위한 메서드
        public Account(string bank, string id, string name, int balance)
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }


        //기능 : 일반적으로 외부에 기능을 제공하기 위한 public 선언

        public void Deposit(int _money)
        {
            this.balance += _money;            // 가독성을 위해 this 추가
        }

        public void WithDraw(int _money)
        {
            this.balance -= _money;
        }
        public void Show()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("계좌 은행명 : " +bank );
            Console.WriteLine("계좌번호 : " + id );
            Console.WriteLine("거래자 : " +name );
            Console.WriteLine("현재 잔액 : " +balance );
            Console.WriteLine("===========================");
        }
    }
}

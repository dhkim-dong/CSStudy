using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Account
    {
        //속성
        public string bank;
        public string id;
        public string name;
        public int balance;


        //기능

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

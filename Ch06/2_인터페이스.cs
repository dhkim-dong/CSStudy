using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 날짜 : 2022/07/20
 * 이름 : 김동훈
 * 내용 : 인터페이스 실습하기 교재 P425
 * 
 * 인터페이스(Interface)
 *  - 클래스 설계를 위해 공통의 표준 가이드 역할을 위한 구조체
 *  - 인터페이스를 활용해서 객체간 결합도를 완화
 */

namespace Ch06
{
    internal class _2_인터페이스
    {
        static void Main1(string[] args)
        {

            //인터페이스로 공통 클래스 구조설계에 활용
            IRemoteControl lg = new LGRemoteControl();
            IRemoteControl sg = new SamSungRemoteControl();

            lg.PowerOn();
            lg.ChUp();
            lg.SoundUp();

            sg.PowerOn();
            sg.ChUp();
            sg.SoundUp();

            //인터페이스로 다중 상속에 활용
            TV smartTV = new TV();
            smartTV.PowerOn();
            smartTV.Booting();
            smartTV.AccessInternet();


            //인터페이스로 객체간 결합도 완화에 활용
            Bulb bulb = new Bulb();
            ISocket socket = new Cable(bulb);  // Cable 클래스는 ISocket을 구현하고 있다. 결합도 완화를 위해서 ISocket 클래스 사용 : Cable클래스는 ISocket을 인터페이스를 구현하고 있다.

            socket.SwitchOn();
            socket.SwitchOff();
        }
    }
}

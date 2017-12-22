using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegSample
{
    delegate void DelegEvent(); // delegate의 준비
    class EventClass
    {
        public event DelegEvent delegevent; // 이벤트 선언

        public void start()
        {
            if (delegevent != null) // delegate가 등록되어 있는지 확인함
            {
                System.Threading.Thread.Sleep(3000); // 3초간 정지
                delegevent(); // 이벤트 호출
            }
        }
    }

    //delegate int DelegMsgs();

    class DelegSample
    {
        //static int print1()
        //{
        //    Console.WriteLine("print1");
        //    return 1;
        //}
        //static int print2()
        //{
        //    Console.WriteLine("print2");
        //    return 2;
        //}
        static void handler()
        {
            Console.WriteLine("핸들러가 호출되었습니다.");
            Console.ReadKey();
        }
        static void Main(string[] args) // 이벤트 등록
        {
            //DelegMsgs deleg;
            //deleg = new DelegMsgs(print1);
            //deleg += new DelegMsgs(print2);
            //int n = deleg();
            //Console.WriteLine(n);
            //Console.ReadKey();

            EventClass e = new EventClass();
            e.delegevent += new DelegEvent(handler);
            e.start();  // 이벤트 클래스 메소드 호출
        }
    }
}

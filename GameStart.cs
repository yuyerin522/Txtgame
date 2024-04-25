using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Txtgame
{
    public  class GameStart //게임시작화면
    {

        public void Start()  // 시작화면
        {
            // 1.게임시작화면
            // 게임 시작 시 간단한 소개 말과 마을에서 할 수 있는 행동을 알려줍니다.

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");

            // 1 (1)  원하는 숫자 행동 타이핑하면 실행합니다

            Console.WriteLine("1:상태보기 / 2: 인벤토리 / 3: 상점");
            Console.WriteLine("원하시는 행동을 입력하세요");
            Console.Write(">> ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":  //1(2) 상태보기

                    string back = Console.ReadLine(); //다시 처음 화면으로 돌아가기

                    Console.WriteLine("1. 상태보기");
                    Console.WriteLine("캐릭터의 정보가 표시됩니다.");







                    break;
                case "2":
                    Console.WriteLine("2. 인벤토리");
                    break;
                case "3":
                    Console.WriteLine("3. 상점");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다");
                    break;
            }

        }
    }
}

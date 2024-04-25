using System.Runtime.CompilerServices;

namespace Txtgame
{
    internal class Program
    {
        //캐릭터 스텟은 아이템에 따라 변하기 때문에 변수로 지정
        static int level = 1;
        static string name = "Chad";
        static string job = "전사";
        static int attack = 10;
        static int defense = 5;
        static int health = 100;
        static int gold = 1500;

        static string[] inventory = new string[10]; // 인벤토리 배열. 최대 10개의 아이템을 보관
        static int inventoryCount = 0;              // 현재 인벤토리에 있는 아이템의 개수
        static bool[] equippedItems = new bool[10]; // 장착된 아이템을 추적하는 배열. 인벤토리의 각 아이템에 대해 장착 여부


        static void Main (string[] args) //메인화면
        { 
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다");
                Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");

                Console.WriteLine();
                Console.WriteLine("1:상태보기 / 2: 인벤토리 / 3: 상점");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력하세요");
                Console.Write(">> ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":  //1(1) 상태보기

                        ShowInfo();
                        break;

                    case "2": //1(2) 인벤토리
                        ShowInven();
                        break;

                    case "3": //1(3) 상점
                        ShowStore();
                        break;

                    default:  //1(4) 잘못선택
                        Console.WriteLine("잘못된 입력입니다");                      
                        break;
                }
            }
        }

        static void ShowInfo () //1(1) 상태보기
        {
            bool exit = false;

            while (!exit)
            {
                // 시작 멘트
                Console.Clear();
                Console.WriteLine("상태보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다");
                Console.WriteLine();

                // 캐릭터 스탯
                Console.WriteLine($"Lv. {level:D2}");
                Console.WriteLine($"{name} ( {job} )");
                Console.WriteLine($"공격력 : {attack}");
                Console.WriteLine($"방어력 : {defense}");
                Console.WriteLine($"체 력 : {health}");
                Console.WriteLine($"Gold : {gold} G");

                //나가기 멘트
                Console.WriteLine();
                Console.WriteLine("0. 나가기");              
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다");
                        break;
                }
            }
        }

        static void ShowInven() //1(2) 인벤토리
        {
            
            bool exit = false;

            while (!exit)
            {
                
                //시작 멘트
                Console.Clear();
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine();

                //아이템이 있을 시 아이템 목록
                //아이템이 없을 시 아이템이 없습니다. 뜨게 하면 될듯

                if (inventoryCount == 0)
                {
                    Console.WriteLine("보유 중인 아이템이 없습니다.");
                }
                else
                {
                    Console.WriteLine("[아이템 목록]");
                    Console.WriteLine();

                    for (int i = 0; i < inventoryCount; i++)
                    {
                        Console.WriteLine($"{i + 1}. {inventory[i]}");
                    }
                }

                //장착 관리, 나가기 멘트
                Console.WriteLine();
                Console.WriteLine("1. 장착관리");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("원하시는 행동을 입력하세요");
                Console.Write(">> ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ItemInfo(); // 1을 입력하면 장착관리
                        break;
                    case "0":
                        exit = true; // 0을 입력하면 나가기
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다");
                        break;
                }


            }
            
        }

        static void ShowStore() //1(3) 상점
        {
            bool exit = false;

            while (!exit)
            {
                //시작 멘트
                Console.Clear();
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다");

                Console.WriteLine();
                Console.WriteLine("[ 보유골드:" + gold + "G ]");






                //나가기 멘트
                Console.WriteLine();
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("원하시는 행동을 입력하세요");
                Console.Write(">> ");


                string choice = Console.ReadLine();

                switch (choice)
                {                
                    case "0":
                        exit = true; // 0을 입력하면 나가기
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다");
                        break;
                }
            }
        }


        static void ItemInfo()  // 인벤토리 - 장착관리
        {
            bool exit = false;

            while (!exit)
            {
                //시작멘트
                Console.Clear();
                Console.WriteLine("인벤토리 - 장착관리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다");



                for (int i = 0; i < inventoryCount; i++)
                {
                    string equippedStatus = equippedItems[i] ? "[E] " : ""; // 장착 중인 아이템은 "[E] "를 표시함
                    Console.WriteLine($"{i + 1}. {equippedStatus}{inventory[i]}");
                }

                



                Console.WriteLine();
                Console.WriteLine("아이템 번호를 입력하여 장착 또는 해제하세요.");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine("원하시는 행동을 입력하세요");
                Console.Write(">> ");

                string choice = Console.ReadLine();

                switch (choice)
                {                   
                    case "0":
                        exit = true; // 0을 입력하면 나가기
                        break;                  
                }
            }
        }


    }
}

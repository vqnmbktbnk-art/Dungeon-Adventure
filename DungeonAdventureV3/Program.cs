namespace DungeonAdventureV3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("欢迎游玩");
        InputProcessing inputs = new InputProcessing();
        while (true)
        {
            Console.WriteLine("按1开始游戏 按2退出游戏");
            Console.Write("在此输入:");
            int input = inputs.InputConversion();
            if (input == 1)
            {
                Console.WriteLine("正在创建房间。。。");
                Thread.Sleep(600);
                Console.WriteLine("创建完成!");

                MusicEvent music = new MusicEvent();
                BattleRoom battleRoom = new BattleRoom();
            }
            else if (input == 2)
            {
                break;
            }
        }
        Console.WriteLine("欢迎下次游玩");
    }
}

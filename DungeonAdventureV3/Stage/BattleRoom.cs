public class BattleRoom
{
    public BattleRoom()
    {
        Battle();
    }

    EnemyGenerate enemyGenerate = new EnemyGenerate();
    InputProcessing inputProcessing = new InputProcessing();
    Player player = new Player();
    Random random = new Random();

    private enum Input
    {
        TakeDamage = 1,  //攻击
        Dodge = 2        //躲避
    }

    private void Battle()
    {
        int amount = enemyGenerate.AddEnemy(); //生成敌人
        Console.WriteLine("本房间为战斗房间，一共有{0}名敌人",amount);
        Console.WriteLine("按1对敌人发动攻击，按2躲避攻击");

        do
        {
            if (enemyGenerate.EnemyCount == 0) break;
            EnTemplate enTemplate = enemyGenerate.ThisEnemy(0);    //获取活着的第一个敌人
            if (enTemplate.Health <= 0)
            {
                enemyGenerate.RemoveEnemy(0);
                continue;
            }
            string? playerinput = Console.ReadLine();
            int input = inputProcessing.InputConversion(playerinput);
            int enemyChose = random.Next(1,3);  //敌人的选择

            Specificbattle(input , enemyChose , enTemplate);
        }
        while (player.Health > 0);

        enemyGenerate.ClearEnemy();   
    }
    private void Specificbattle(int input , int enemyChose , EnTemplate enTemplate)
    {
         if (input == 1 && enemyChose == 1)
            {
                Console.WriteLine("你和敌人都选择进攻");
                enTemplate.Health = player.NormalAttack(enTemplate.Health);
                player.Health = enTemplate.NormalAttack(player.Health);
            }
            else if (input == 1 && enemyChose == 2)
            {
                Console.WriteLine("你选择进攻但敌人选择了躲避");
            }
            else if (input == 2 && enemyChose == 1)
            {
                Console.WriteLine("你选择躲避，刚好躲掉敌人的进攻");
            }
            else if (input == 2 && enemyChose == 2)
            {
                Console.WriteLine("你和敌人都选择躲避，谨慎观望");
            }
            Console.WriteLine("你的血量：{0}/100",player.Health);
            Console.WriteLine("{0}的血量：{1}/100",enTemplate.Name,enTemplate.Health);
    }
}
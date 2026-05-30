public class BattleSerice
{
    Goblin goblin = new Goblin();
    Skeleton skeleton = new Skeleton();
    Dragon dragon = new Dragon();
    Warrior warrior = new Warrior();
    Random random = new Random();
    public void WarriorBattle()
    {
        bool Health = true;
        while (Health)
        {
            Console.WriteLine("按1使用技能：暴击 按2使用技能：横扫 按3使用普通攻击");
            int? a = Covernt(Console.ReadLine());
            PersonEventArgs personEventArgs = new PersonEventArgs(goblin , skeleton , warrior , a);
            if (a == 1 || a == 2)
            {
                if (a == 1)
                {
                   
                }
                else if (a == 2)
                {
                   
                }
                Console.WriteLine("哥布林血量:{0}/100",goblin.Health);
            }
            else if (a == 3)
            {
               int AttackPower = warrior.Attack(warrior.AttackPower,warrior.Magicpower);
               goblin.Health = warrior.Damage(goblin.Health , AttackPower , goblin.Defense);
               Console.WriteLine("哥布林血量:{0}/100",goblin.Health);
            }
            else
            {
               Console.WriteLine("输入有效数字");
            }
            int number = random.Next(1,4);
            if (number == 1)
            {
                warrior.Health = goblin.Attack(warrior.Health);
                Console.WriteLine("你受到哥布林的攻击，你的血量:{0}/100",warrior.Health);
            }
            else if (number == 2)
            {
                warrior.Health = goblin.JumpDamage(warrior.Health,warrior.Defense);
                Console.WriteLine("你受到哥布林的技能跳劈，你的血量:{0}/100",warrior.Health);
            }
            else if (number == 3)
            {
                warrior.Health = goblin.Thrust(warrior.Health,warrior.Defense);
                Console.WriteLine("你受到哥布林的技能直刺，你的血量:{0}/100",warrior.Health);
            }
            else
            {
                Console.WriteLine("哥布林本次选择不进攻");
            }

            if (goblin.Health <= 0)
            {
                Console.WriteLine("哥布林已死亡");
                return;
            }
            if (warrior.Health <= 0)
            {
                Console.WriteLine("你已死亡");
                return;
            }
        }
    }
    private static int? Covernt(string? a)
    {
        int b;
        if (int.TryParse(a ,out b) && a != null)
        {
            return b;
        }
        else
        {
            throw new Exception("转换失败");
        }
    }
}
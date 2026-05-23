public class WarriorBattleService
{
    public void WarriorButtleGoblin()   //战士打哥布林
    {
        Random random = new Random();
        Warrior warrior = new Warrior();
        Goblin goblin = new Goblin();
        SkillManager skillManager = new SkillManager();
        GoblinEventArgs goblinEventArgs = new GoblinEventArgs(goblin);

        while (goblin.Health > 0 && warrior.Health > 0)
        {
            Console.WriteLine("按1使用技能：暴击 按2使用技能：横扫 按3使用普通攻击");
            string? b = Console.ReadLine();
            int a = Covernt(b);
            if (a == 1 || a == 2)
            {
                Thread Skill = new Thread(() => skillManager.WarriorSkillOnGoblin(a, goblinEventArgs));
                Skill.Start();
                Console.WriteLine("技能冷却中。。。");
                if (a == 1)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.criticalHit.CoolingTime*100);
                }
                else if (a == 2)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.sweep.CoolingTime*100);
                }
                Console.WriteLine("冷却完成");
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
    public void WarriorButtleSkeleton() //战士打骷髅
    {
        Random random = new Random();
        Warrior warrior = new Warrior();
        Skeleton skeleton = new Skeleton();
        SkillManager skillManager = new SkillManager();
        SkeletonEventArgs skeletonEventArgs = new SkeletonEventArgs(skeleton);

        while (skeleton.Health > 0 && warrior.Health > 0)
        {
            Console.WriteLine("按1使用技能：暴击 按2使用技能：横扫 按3使用普通攻击");
            string? b = Console.ReadLine();
            int a = Covernt(b);
            if (a == 1 || a == 2)
            {
                Thread Skill = new Thread(() => skillManager.WarriorSkillOnSkeleton(a, skeletonEventArgs));
                Skill.Start();
                Console.WriteLine("技能冷却中。。。");
                if (a == 1)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.criticalHit.CoolingTime);
                   Console.WriteLine("冷却完成");
                }
                else if (a == 2)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.sweep.CoolingTime);
                   Console.WriteLine("冷却完成");
                }
            }
            else if (a == 3)
            {
               int AttackPower = warrior.Attack(warrior.AttackPower,warrior.Magicpower);
               skeleton.Health = warrior.Damage(skeleton.Health , AttackPower , skeleton.Defense);
            }
            else
            {
               Console.WriteLine("输入有效数字");
            }
            int number = random.Next(1,3);
            if (number == 1)
            {
                warrior.Health = skeleton.Attack(warrior.Health);
            }
            else if (number == 2)
            {
                warrior.Health = skeleton.SpeedArrow(warrior.Health,warrior.Defense);
            }
            else
            {
                Console.WriteLine("骷髅本次选择不进攻");
            }

            if (skeleton.Health == 0)
            {
                Console.WriteLine("骷髅已死亡");
                return;
            }
            if (warrior.Health == 0)
            {
                Console.WriteLine("你已死亡");
                return;
            }
        }
    }
    public void WarriorButtleDragon()   //战士打龙
    {
        Random random = new Random();
        Warrior warrior = new Warrior();
        Dragon dragon = new Dragon();
        SkillManager skillManager = new SkillManager();
        DragonEventArgs dragonEventArgs = new DragonEventArgs(dragon);

        while (dragon.Health > 0 && warrior.Health > 0)
        {
            Console.WriteLine("按1使用技能：暴击 按2使用技能：横扫 按3使用普通攻击");
            string? b = Console.ReadLine();
            int a = Covernt(b);
            if (a == 1 || a == 2)
            {
                Thread Skill = new Thread(() => skillManager.WarriorSkillOnDragon(a, dragonEventArgs));
                Skill.Start();
                Console.WriteLine("技能冷却中。。。");
                if (a == 1)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.criticalHit.CoolingTime);
                   Console.WriteLine("冷却完成");
                }
                else if (a == 2)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.sweep.CoolingTime);
                   Console.WriteLine("冷却完成");
                }
            }
            else if (a == 3)
            {
               int AttackPower = warrior.Attack(warrior.AttackPower,warrior.Magicpower);
               dragon.Health = warrior.Damage(dragon.Health , AttackPower , dragon.Defense);
            }
            else
            {
               Console.WriteLine("输入有效数字");
            }
            int number = random.Next(1,4);
            if (number == 1)
            {
                warrior.Health = dragon.Attack(warrior.Health);
            }
            else if (number == 2)
            {
                warrior.Health = dragon.FireBall(warrior.Health,warrior.Defense);
            }
            else if (number == 3 || dragon.Health<50)
            {
                dragon.Health = dragon.Heal(dragon.Health);
            }
            else
            {
                Console.WriteLine("龙本次选择不进攻");
            }

            if (dragon.Health == 0)
            {
                Console.WriteLine("龙已死亡");
                return;
            }
            if (warrior.Health == 0)
            {
                Console.WriteLine("你已死亡");
                return;
            }
        }
    }

     public void MageButtleGoblin()   //法师打哥布林
    {
        Random random = new Random();
        Mage mage = new Mage();
        Goblin goblin = new Goblin();
        SkillManager skillManager = new SkillManager();
        GoblinEventArgs goblinEventArgs = new GoblinEventArgs(goblin);

        while (goblin.Health > 0 && mage.Health > 0)
        {
            Console.WriteLine("按1使用技能：暴击 按2使用技能：横扫 按3使用普通攻击");
            string? b = Console.ReadLine();
            int a = Covernt(b);
            if (a == 1 || a == 2)
            {
                Thread Skill = new Thread(() => skillManager.MageSkillOnGoblin(a, goblinEventArgs));
                Skill.Start();
                Console.WriteLine("技能冷却中。。。");
                if (a == 1)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.iceSpike.CoolingTime*100);
                }
                else if (a == 2)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.fireAttack.CoolingTime*100);
                }
                Console.WriteLine("冷却完成");
                Console.WriteLine("哥布林血量:{0}/100",goblin.Health);
            }
            else if (a == 3)
            {
               int AttackPower = mage.Attack(mage.AttackPower,mage.Magicpower);
               goblin.Health = mage.Damage(goblin.Health , AttackPower , goblin.Defense);
               Console.WriteLine("哥布林血量:{0}/100",goblin.Health);
            }
            else
            {
               Console.WriteLine("输入有效数字");
            }
            int number = random.Next(1,4);
            if (number == 1)
            {
                mage.Health = goblin.Attack(mage.Health);
                Console.WriteLine("你受到哥布林的攻击，你的血量:{0}/100",mage.Health);
            }
            else if (number == 2)
            {
                mage.Health = goblin.JumpDamage(mage.Health,mage.Defense);
                Console.WriteLine("你受到哥布林的技能跳劈，你的血量:{0}/100",mage.Health);
            }
            else if (number == 3)
            {
                mage.Health = goblin.Thrust(mage.Health,mage.Defense);
                Console.WriteLine("你受到哥布林的技能直刺，你的血量:{0}/100",mage.Health);
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
            if (mage.Health <= 0)
            {
                Console.WriteLine("你已死亡");
                return;
            }
        }
    }
    public void MageButtleSkeleton()   //法师打骷髅
    {
        Random random = new Random();
        Mage mage = new Mage();
        Skeleton skeleton = new Skeleton();
        SkillManager skillManager = new SkillManager();
        SkeletonEventArgs skeletonEventArgs = new SkeletonEventArgs(skeleton);

        while (skeleton.Health > 0 && mage.Health > 0)
        {
            Console.WriteLine("按1使用技能：暴击 按2使用技能：横扫 按3使用普通攻击");
            string? b = Console.ReadLine();
            int a = Covernt(b);
            if (a == 1 || a == 2)
            {
                Thread Skill = new Thread(() => skillManager.WarriorSkillOnSkeleton(a, skeletonEventArgs));
                Skill.Start();
                Console.WriteLine("技能冷却中。。。");
                if (a == 1)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.iceSpike.CoolingTime);
                   Console.WriteLine("冷却完成");
                }
                else if (a == 2)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.fireAttack.CoolingTime);
                   Console.WriteLine("冷却完成");
                }
            }
            else if (a == 3)
            {
               int AttackPower = mage.Attack(mage.AttackPower,mage.Magicpower);
               skeleton.Health = mage.Damage(skeleton.Health , AttackPower , skeleton.Defense);
            }
            else
            {
               Console.WriteLine("输入有效数字");
            }
            int number = random.Next(1,3);
            if (number == 1)
            {
                mage.Health = skeleton.Attack(mage.Health);
            }
            else if (number == 2)
            {
                mage.Health = skeleton.SpeedArrow(mage.Health,mage.Defense);
            }
            else
            {
                Console.WriteLine("骷髅本次选择不进攻");
            }

            if (skeleton.Health == 0)
            {
                Console.WriteLine("骷髅已死亡");
                return;
            }
            if (mage.Health == 0)
            {
                Console.WriteLine("你已死亡");
                return;
            }
        }
    }
    
     public void MageButtleDragon()   //法师打龙
    {
        Random random = new Random();
        Mage mage = new Mage();
        Dragon dragon = new Dragon();
        SkillManager skillManager = new SkillManager();
        DragonEventArgs dragonEventArgs = new DragonEventArgs(dragon);

        while (dragon.Health > 0 && mage.Health > 0)
        {
            Console.WriteLine("按1使用技能：暴击 按2使用技能：横扫 按3使用普通攻击");
            string? b = Console.ReadLine();
            int a = Covernt(b);
            if (a == 1 || a == 2)
            {
                Thread Skill = new Thread(() => skillManager.WarriorSkillOnDragon(a, dragonEventArgs));
                Skill.Start();
                Console.WriteLine("技能冷却中。。。");
                if (a == 1)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.iceSpike.CoolingTime);
                   Console.WriteLine("冷却完成");
                }
                else if (a == 2)
                {
                   Thread.Sleep(skillManager.skillEventHandlerMethod.fireAttack.CoolingTime);
                   Console.WriteLine("冷却完成");
                }
            }
            else if (a == 3)
            {
               int AttackPower = mage.Attack(mage.AttackPower,mage.Magicpower);
               dragon.Health = mage.Damage(dragon.Health , AttackPower , dragon.Defense);
            }
            else
            {
               Console.WriteLine("输入有效数字");
            }
            int number = random.Next(1,4);
            if (number == 1)
            {
                mage.Health = dragon.Attack(mage.Health);
            }
            else if (number == 2)
            {
                mage.Health = dragon.FireBall(mage.Health,mage.Defense);
            }
            else if (number == 3 || dragon.Health<50)
            {
                dragon.Health = dragon.Heal(dragon.Health);
            }
            else
            {
                Console.WriteLine("龙本次选择不进攻");
            }

            if (dragon.Health == 0)
            {
                Console.WriteLine("龙已死亡");
                return;
            }
            if (mage.Health == 0)
            {
                Console.WriteLine("你已死亡");
                return;
            }
        }
    }

    private int Covernt(string? a)
    {
        int b;
        if (int.TryParse(a , out b))
        {
            return b;
        }
        else
        {
            throw new Exception("转换失败");
        }
    }
}
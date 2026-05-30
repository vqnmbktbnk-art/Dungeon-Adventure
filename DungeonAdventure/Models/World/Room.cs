public class WorriorRoom
{
    WarriorBattleService battle = new WarriorBattleService();
    public enum TheRoom
    {
        FirstRoom,
        SecondRoom,
        ThirdRoom
    }
    public void SuiteRoom(TheRoom theRoom)
    {
        switch (theRoom)
        {
            case TheRoom.FirstRoom:
            int a = Rnumber();
                for (int i = 0;i<a;i++)
                {
                    int b = Rnumber();
                    if (b==1||b==2)
                    {
                        battle.WarriorButtleGoblin();
                    }
                    else
                    {
                        battle.WarriorButtleSkeleton();
                    }
                }
            break;
            case TheRoom.SecondRoom:
              int c = Rnumber();
                for (int i = 0;i<c;i++)
                {
                    int b = Rnumber();
                    if (b==1||b==2)
                    {
                        battle.WarriorButtleGoblin();
                    }
                    else
                    {
                        battle.WarriorButtleSkeleton();
                    }
                }
            break;
            case TheRoom.ThirdRoom:
            int d = Rnumber();
                for (int i = 0;i<d;i++)
                {
                    int b = Rnumber();
                    if (b==1)
                    {
                        battle.WarriorButtleGoblin();
                    }
                    else if(b == 2)
                    {
                        battle.WarriorButtleSkeleton();
                    }
                    else
                    {
                        battle.WarriorButtleDragon();
                    }
                }
            break;
        }
    }
    private int Rnumber()
    {
        Random random = new Random();
        int a = random.Next(1,4);
        return a;
    }
}
public class MageRoom
{
    WarriorBattleService battle = new WarriorBattleService();
    public enum TheRoom
    {
        FirstRoom,
        SecondRoom,
        ThirdRoom
    }
    public void SuiteRoom(TheRoom theRoom)
    {
        switch (theRoom)
        {
            case TheRoom.FirstRoom:
            int a = Rnumber();
                for (int i = 0;i<a;i++)
                {
                    int b = Rnumber();
                    if (b==1||b==2)
                    {
                        battle.MageButtleGoblin();
                    }
                    else
                    {
                        battle.MageButtleSkeleton();
                    }
                }
            break;
            case TheRoom.SecondRoom:
              int c = Rnumber();
                for (int i = 0;i<c;i++)
                {
                    int b = Rnumber();
                    if (b==1||b==2)
                    {
                        battle.MageButtleGoblin();
                    }
                    else
                    {
                        battle.MageButtleSkeleton();
                    }
                }
            break;
            case TheRoom.ThirdRoom:
            int d = Rnumber();
                for (int i = 0;i<d;i++)
                {
                    int b = Rnumber();
                    if (b==1)
                    {
                        battle.MageButtleGoblin();
                    }
                    else if(b == 2)
                    {
                        battle.MageButtleSkeleton();
                    }
                    else
                    {
                        battle.MageButtleDragon();
                    }
                }
            break;
        }
    }
    private int Rnumber()
    {
        Random random = new Random();
        int a = random.Next(1,4);
        return a;
    }
}
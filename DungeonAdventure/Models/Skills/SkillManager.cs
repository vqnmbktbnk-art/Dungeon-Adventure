using System.Security.Cryptography.X509Certificates;

public class GoblinEventArgs : EventArgs                                 //哥布林
{
    public Goblin goblin;
    public GoblinEventArgs(Goblin goblin)
    {
        this.goblin = goblin;
    }
}
public class SkeletonEventArgs : EventArgs                               //骷髅
{
    public Skeleton skeleton;
    public SkeletonEventArgs(Skeleton skeleton)
    {
        this.skeleton = skeleton;
    }
}
public class DragonEventArgs : EventArgs                                 //龙
{
    public Dragon dragon;
    public DragonEventArgs(Dragon dragon)
    {
        this.dragon = dragon;
    }
}
public class WarriorEventArgs : EventArgs                                //战士
{
    public Warrior warrior;
    public WarriorEventArgs(Warrior warrior)
    {
        this.warrior = warrior;
    }
}
public class MageEventArgs : EventArgs                                   //法师
{
    public Mage mage;
    public MageEventArgs(Mage mage)
    {
        this.mage = mage;
    }
}
public class RangerEventArgs : EventArgs                                 //法师
{
    public Ranger ranger;
    public RangerEventArgs(Ranger ranger)
    {
        this.ranger = ranger;
    }
}
public class SkillEventHandler
{
    public event EventHandler<GoblinEventArgs>? WarriorSkillEvent;
    protected virtual void OnWarriorSkillEvent(GoblinEventArgs e)
    {
        WarriorSkillEvent?.Invoke(this,e);
    }
    public void OnWarriorSkill(GoblinEventArgs e)
    {
        OnWarriorSkillEvent(e);
    }

    public event EventHandler<SkeletonEventArgs>? MageSkillEvent;
    protected virtual void OnMageSkillEvent(SkeletonEventArgs e)
    {
        MageSkillEvent?.Invoke(this,e);
    }
    public void OnMageSkill(SkeletonEventArgs e)
    {
        OnMageSkillEvent(e);
    }

    public event EventHandler<DragonEventArgs>? RangerSkillEvent;
    protected virtual void OnRangerSkillEvent(DragonEventArgs e)
    {
        RangerSkillEvent?.Invoke(this,e);
    }
    public void OnRangerSkill(DragonEventArgs e)
    {
        OnRangerSkillEvent(e);
    }
}
public class SkillEventHandlerMethod
{
    public CriticalHit criticalHit = new CriticalHit();    //技能:暴击
    public Sweep sweep = new Sweep();                      //技能:横扫
    public IceSpike iceSpike = new IceSpike();             //技能:冰刺
    public FireAttack fireAttack = new FireAttack();       //技能:火攻
    public ShieldMountain shieldMountain = new ShieldMountain();  //技能:盾山

    public void GoblinCriticalHitSkill(object? sender , GoblinEventArgs e)       //哥布林受到暴击技能
    {
        e.goblin.Health = criticalHit.CloseSkills(e.goblin.Health);
    }
    public void GoblinSweepSkill(object? sender , GoblinEventArgs e)             //哥布林受到横扫技能
    {
        e.goblin.Health = sweep.CloseSkills(e.goblin.Health);
    }
    public void GoblinIceSpikeSkill(object? sender , GoblinEventArgs e)          //哥布林受到冰刺技能
    {
        e.goblin.Health = iceSpike.MagicSkills(e.goblin.Health);
    }
    public void GoblinFireAttackSkill(object? sender , GoblinEventArgs e)        //哥布林受到火攻技能
    {
        e.goblin.Health = fireAttack.MagicSkills(e.goblin.Health);
    }

    public void SkeletonCriticalHitSkill(object? sender , SkeletonEventArgs e)  //骷髅受到暴击技能
    {
        e.skeleton.Health = criticalHit.CloseSkills(e.skeleton.Health);
    }
    public void SkeletonSweepSkill(object? sender , SkeletonEventArgs e)        //骷髅受到横扫技能
    {
        e.skeleton.Health = sweep.CloseSkills(e.skeleton.Health);
    }
    public void SkeletonIceSpikeSkill(object? sender , SkeletonEventArgs e)     //骷髅受到冰刺技能
    {
        e.skeleton.Health = iceSpike.MagicSkills(e.skeleton.Health);
    }
    public void SkeletonFireAttackSkill(object? sender , SkeletonEventArgs e)   //骷髅受到火攻技能
    {
        e.skeleton.Health = fireAttack.MagicSkills(e.skeleton.Health);
    }

    public void DragonCriticalHitSkill(object? sender , DragonEventArgs e)      //龙受到暴击技能
    {
        e.dragon.Health = criticalHit.CloseSkills(e.dragon.Health);
    }
    public void DragonSweepSkill(object? sender , DragonEventArgs e)            //龙受到横扫技能
    {
        e.dragon.Health = sweep.CloseSkills(e.dragon.Health);
    }
    public void DragonIceSpikeSkill(object? sender , DragonEventArgs e)         //龙受到冰刺技能
    {
        e.dragon.Health = iceSpike.MagicSkills(e.dragon.Health);
    }
    public void DragonFireAttackSkill(object? sender , DragonEventArgs e)       //龙受到火攻技能
    {
        e.dragon.Health = fireAttack.MagicSkills(e.dragon.Health);
    }

    public void WarriorShieldMountain(object? sender , WarriorEventArgs e)      //战士使用盾山技能
    {
        e.warrior.Defense = shieldMountain.DefenseSkills(e.warrior.Defense);
    }
}
public class SkillManager
{
    SkillEventHandler skillEventHandler = new SkillEventHandler();
    SkillEventHandlerMethod skillEventHandlerMethod = new SkillEventHandlerMethod();
    public SkillManager()
    {
        
    }
    public void WarriorSkillEvent(int a , object e)
    {
        if (e is Goblin)
        {
            if (a == 1)
            {
                skillEventHandler.WarriorSkillEvent += skillEventHandlerMethod.GoblinCriticalHitSkill;
            }
            else if (a == 2)
            {
                skillEventHandler.WarriorSkillEvent += skillEventHandlerMethod.GoblinSweepSkill;
            }
            try
            {
                Goblin goblin = (Goblin)e;
                skillEventHandler.OnWarriorSkill(new GoblinEventArgs(goblin));
            }
            catch
            {
                Console.WriteLine("转换出现问题");
                throw new InvalidCastException(nameof(Goblin));
            }
            finally
            {
                skillEventHandler.WarriorSkillEvent -= skillEventHandlerMethod.GoblinCriticalHitSkill;
                skillEventHandler.WarriorSkillEvent -= skillEventHandlerMethod.GoblinSweepSkill;
            }
        }
        else
        {
            Console.WriteLine("方法输入的类型不正确");
            return;
        }
    }
}
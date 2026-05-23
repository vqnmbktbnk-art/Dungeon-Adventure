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
public class SkillEventHandler
{
    public event EventHandler<GoblinEventArgs>? WarriorSkillGoblinEvent;  //战士对哥布林的事件
    protected virtual void OnWarriorSkillGoblinEvent(GoblinEventArgs e)
    {
        WarriorSkillGoblinEvent?.Invoke(this,e);
    }
    public void OnWarriorSkillGoblin(GoblinEventArgs e)
    {
        OnWarriorSkillGoblinEvent(e);
    }

    public event EventHandler<SkeletonEventArgs>? WarriorSkillSkeletonEvent;  //战士对骷髅的事件
    protected virtual void OnWarriorSkillSkeletonEvent(SkeletonEventArgs e)
    {
        WarriorSkillSkeletonEvent?.Invoke(this,e);
    }
    public void OnWarriorSkillSkeleton(SkeletonEventArgs e)
    {
        OnWarriorSkillSkeleton(e);
    }

    public event EventHandler<DragonEventArgs>? WarriorSkillDragonEvent;    //战士对龙的事件
    protected virtual void OnWarriorSkillDragonEvent(DragonEventArgs e)
    {
        WarriorSkillDragonEvent?.Invoke(this,e);
    }
    public void OnWarriorSkillDragon(DragonEventArgs e)
    {
        OnWarriorSkillDragonEvent(e);
    }

    public event EventHandler<GoblinEventArgs>? MageSkillGoblinEvent;      //法师对哥布林的事件
    protected virtual void OnMageSkillGoblinEvent(GoblinEventArgs e)
    {
        MageSkillGoblinEvent?.Invoke(this,e);
    }
    public void OnMageSkillGoblin(GoblinEventArgs e)
    {
        OnMageSkillGoblinEvent(e);
    }

    public event EventHandler<SkeletonEventArgs>? MageSkillSkeletonEvent;  //法师对骷髅的事件
    protected virtual void OnMageSkillSkeletonEvent(SkeletonEventArgs e)
    {
        MageSkillSkeletonEvent?.Invoke(this,e);
    }
    public void OnMageSkillSkeleton(SkeletonEventArgs e)
    {
        OnMageSkillSkeletonEvent(e);
    }

    public event EventHandler<DragonEventArgs>? MageSkillDragonEvent;     //法师对龙的事件
    protected virtual void OnMageSkillDragonEvent(DragonEventArgs e)
    {
        MageSkillDragonEvent?.Invoke(this,e);
    }
    public void OnRangerDragonSkill(DragonEventArgs e)
    {
        OnMageSkillDragonEvent(e);
    }
}
public class SkillEventHandlerMethod
{
    public CriticalHit criticalHit = new CriticalHit();    //技能:暴击
    public Sweep sweep = new Sweep();                      //技能:横扫
    public IceSpike iceSpike = new IceSpike();             //技能:冰刺
    public FireAttack fireAttack = new FireAttack();       //技能:火攻

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

}
public class SkillManager
{
    SkillEventHandler skillEventHandler = new SkillEventHandler();
    public SkillEventHandlerMethod skillEventHandlerMethod = new SkillEventHandlerMethod();
    public void WarriorSkillOnGoblin(int a , GoblinEventArgs e)
    {
        if (a == 1)
        {
            skillEventHandler.WarriorSkillGoblinEvent += skillEventHandlerMethod.GoblinCriticalHitSkill;
        }
        else if(a == 2)
        {
            skillEventHandler.WarriorSkillGoblinEvent += skillEventHandlerMethod.GoblinSweepSkill;
        }

        skillEventHandler.OnWarriorSkillGoblin(e);

        skillEventHandler.WarriorSkillGoblinEvent -= skillEventHandlerMethod.GoblinCriticalHitSkill;
        skillEventHandler.WarriorSkillGoblinEvent -= skillEventHandlerMethod.GoblinSweepSkill;
    }
    public void WarriorSkillOnSkeleton(int a , SkeletonEventArgs e)
    {
        if (a == 1)
        {
            skillEventHandler.WarriorSkillSkeletonEvent += skillEventHandlerMethod.SkeletonCriticalHitSkill;
        }
        else if(a == 2)
        {
            skillEventHandler.WarriorSkillSkeletonEvent += skillEventHandlerMethod.SkeletonSweepSkill;
        }

        skillEventHandler.OnWarriorSkillSkeleton(e);

        skillEventHandler.WarriorSkillSkeletonEvent -= skillEventHandlerMethod.SkeletonCriticalHitSkill;
        skillEventHandler.WarriorSkillSkeletonEvent -= skillEventHandlerMethod.SkeletonSweepSkill;
    }
    public void WarriorSkillOnDragon(int a , DragonEventArgs e)
    {
        if (a == 1)
        {
            skillEventHandler.WarriorSkillDragonEvent += skillEventHandlerMethod.DragonCriticalHitSkill;
        }
        else if(a == 2)
        {
            skillEventHandler.WarriorSkillDragonEvent += skillEventHandlerMethod.DragonSweepSkill;
        }

        skillEventHandler.OnWarriorSkillDragon(e);

        skillEventHandler.WarriorSkillDragonEvent -= skillEventHandlerMethod.DragonCriticalHitSkill;
        skillEventHandler.WarriorSkillDragonEvent -= skillEventHandlerMethod.DragonSweepSkill;
    }
    public void MageSkillOnGoblin(int a , GoblinEventArgs e)
    {
        if (a == 1)
        {
            skillEventHandler.MageSkillGoblinEvent += skillEventHandlerMethod.GoblinIceSpikeSkill;
        }
        else if (a == 2)
        {
            skillEventHandler.MageSkillGoblinEvent += skillEventHandlerMethod.GoblinFireAttackSkill;
        }

        skillEventHandler.OnMageSkillGoblin(e);

        skillEventHandler.MageSkillGoblinEvent -= skillEventHandlerMethod.GoblinIceSpikeSkill;
        skillEventHandler.MageSkillGoblinEvent -= skillEventHandlerMethod.GoblinFireAttackSkill;
    }
    public void MageSkillOnSkeleton(int a , SkeletonEventArgs e)
    {
        if (a == 1)
        {
            skillEventHandler.MageSkillSkeletonEvent += skillEventHandlerMethod.SkeletonIceSpikeSkill;
        }
        else if (a == 2)
        {
            skillEventHandler.MageSkillSkeletonEvent += skillEventHandlerMethod.SkeletonFireAttackSkill;
        }

        skillEventHandler.OnMageSkillSkeleton(e);

        skillEventHandler.MageSkillSkeletonEvent -= skillEventHandlerMethod.SkeletonIceSpikeSkill;
        skillEventHandler.MageSkillSkeletonEvent -= skillEventHandlerMethod.SkeletonFireAttackSkill;
    }
    public void MageSkillOnDragon(int a , DragonEventArgs e)
    {
        if (a == 1)
        {
            skillEventHandler.MageSkillDragonEvent += skillEventHandlerMethod.DragonIceSpikeSkill;
        }
        else if (a == 2)
        {
            skillEventHandler.MageSkillDragonEvent += skillEventHandlerMethod.DragonFireAttackSkill;
        }

        skillEventHandler.OnRangerDragonSkill(e);

        skillEventHandler.MageSkillDragonEvent -= skillEventHandlerMethod.DragonIceSpikeSkill;
        skillEventHandler.MageSkillDragonEvent -= skillEventHandlerMethod.DragonFireAttackSkill;
    } 
}
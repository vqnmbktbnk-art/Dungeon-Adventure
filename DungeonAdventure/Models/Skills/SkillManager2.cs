public class PersonEventArgs : EventArgs
{
    public int goblin{get;set;}
    public int skeleton{get;set;}
    public int dragon{get;set;}
    public int warrior{get;set;}
    public int? skillOrder{get;}
    public PersonEventArgs(Goblin goblin ,  Skeleton skeleton , Warrior warrior , int? skillOrder)
    {
        this.goblin = goblin.Health;
        this.skeleton = skeleton.Health;
        this.warrior = warrior.Defense;
        this.skillOrder = skillOrder;
    }
    public PersonEventArgs(Dragon dragon , int? skillOrder)
    {
        this.dragon = dragon.Health;
        this.skillOrder = skillOrder;
    }
}
public class SkillEvent
{
    public event EventHandler<PersonEventArgs>? WarriorEventHandler;
    public event EventHandler<PersonEventArgs>? MageEventHandler;
    private void OnWarriorSkill(PersonEventArgs e)
    {
        WarriorEventHandler?.Invoke(this,e);
    }
    private void OnMageSkill(PersonEventArgs e)
    {
        MageEventHandler?.Invoke(this,e);
    }
    public void WarriorSkill(PersonEventArgs e)
    {
        OnWarriorSkill(e);
    }
    public void MageSkill(PersonEventArgs e)
    {
        OnMageSkill(e);
    }
}
public class SkillMethod
{
    //战士技能
    CriticalHit criticalHit = new CriticalHit();
    ShieldMountain shieldMountain = new ShieldMountain();
    Sweep sweep = new Sweep();
    //法师技能
    IceSpike iceSpike = new IceSpike();
    FireAttack fireAttack = new FireAttack();

    public void WorriorSkill(object? sender , PersonEventArgs e)
    {
        if (sender != null && sender is Goblin goblin)
        {
            if (e.skillOrder == 1)
            {
                e.goblin = criticalHit.CloseSkills(e.goblin);
            }
            else if (e.skillOrder == 2)
            {
                e.goblin = sweep.CloseSkills(e.goblin);
            }
            else if (e.skillOrder == 3)
            {
                e.warrior = shieldMountain.DefenseSkills(e.warrior);
            }
        }
        else if (sender != null && sender is Skeleton skeleton)
        {
            if (e.skillOrder == 1)
            {
                e.skeleton = criticalHit.CloseSkills(e.skeleton);
            }
            else if (e.skillOrder == 2)
            {
                e.skeleton = sweep.CloseSkills(e.skeleton);
            }
            else if (e.skillOrder == 3)
            {
                e.warrior = shieldMountain.DefenseSkills(e.warrior);
            }
        }
        else if (sender != null && sender is Dragon dragon)
        {
            if (e.skillOrder == 1)
            {
                e.dragon = criticalHit.CloseSkills(e.dragon);
            }
            else if (e.skillOrder == 2)
            {
                e.dragon = sweep.CloseSkills(e.dragon);
            }
            else if (e.skillOrder == 3)
            {
                e.warrior = shieldMountain.DefenseSkills(e.warrior);
            }
        }
    }
    public void MageSkill(object? sender , PersonEventArgs e)
    {
        if (sender != null && sender is Goblin goblin)
        {
            if (e.skillOrder == 1)
            {
                e.goblin = iceSpike.MagicSkills(e.goblin);
            }
            else if (e.skillOrder == 2)
            {
                e.goblin = fireAttack.MagicSkills(e.goblin);
            }
        }
        else if (sender != null && sender is Skeleton skeleton)
        {
            if (e.skillOrder == 1)
            {
                e.skeleton = iceSpike.MagicSkills(e.skeleton);
            }
            else if (e.skillOrder == 2)
            {
                e.skeleton = fireAttack.MagicSkills(e.skeleton);
            }
        }
        else if (sender != null && sender is Dragon dragon)
        {
            if (e.skillOrder == 1)
            {
                e.dragon = iceSpike.MagicSkills(e.dragon);
            }
            else if (e.skillOrder == 2)
            {
                e.dragon = fireAttack.MagicSkills(e.dragon);
            }
        }
    }
}
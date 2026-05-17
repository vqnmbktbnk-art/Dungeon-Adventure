public class CriticalHit : Skill , ICloseRange     //技能:暴击
{
    public CriticalHit()
    {
        BasicValue();
    }
    public void BasicValue()
    {
        SkillAttack = 18;
        CoolingTime = 13;
    }
    public int CloseSkills(int Health)         //暴击计算
    {
        int newHealth = Health - SkillAttack;
        return newHealth;
    }
}
public class Sweep : Skill , ICloseRange       //技能:横扫
{
    public Sweep()
    {
        BasicValue();
    }
    public void BasicValue()
    {
        SkillAttack = 11;
        CoolingTime = 10;
    }
    public int CloseSkills(int Health)          //横扫计算
    {
        int newHealth = Health - SkillAttack;
        return newHealth;
    }
}
public class IceSpike : Skill , IMagic         //技能:冰刺
{
    public IceSpike()
    {
        BaseValue();
    }
    public void BaseValue()
    {
        SkillAttack = 20;
        CoolingTime = 22;
    }
    public int MagicSkills(int Health)      //冰刺计算
    {
        int newHealth = Health - SkillAttack;
        return newHealth;
    }
}
public class FireAttack : Skill , IMagic       //技能:火攻
{
    public FireAttack()
    {
        BaseValue();
    }
    public void BaseValue()
    {
        SkillAttack = 25;
        CoolingTime = 25;
    }
    public int MagicSkills(int Health)      //火攻计算
    {
        int newHealth = Health - SkillAttack;
        return newHealth;
    }
}
public class ShieldMountain : Skill , IDefense    //技能:盾山
{
    public ShieldMountain()
    {
        BaseValue();
    }
    public void BaseValue()
    {
        SkillAttack = 0;
        CoolingTime = 25;
    }
    public int DefenseSkills(int Defense)   //给原本的防御增加5
    {
        return Defense + 5;
    }
}
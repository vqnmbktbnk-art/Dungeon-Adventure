public class Skeleton : Enemy  //骷髅
{
    public Skeleton()
    {
        Basevalue();
    }
    public override void Basevalue()
    {
        Health = 50;
        Defense = 2;
        Level = 1;
        Speed = 2;
        AttackPower = 15;
        Magicpower = 6;
    }
    public int Attack(int Health)                     //普通攻击
    {
        int newAttack = AttackPower + Magicpower;
        return Health - newAttack;
    }
    public int SpeedArrow(int Health , int Defense)    //技能:万箭齐发
    {
        int TheHealth = Health + Defense;
        int newHealth = TheHealth - 20;
        return newHealth;
    }
}
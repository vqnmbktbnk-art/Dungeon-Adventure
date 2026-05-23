public class Goblin : Enemy   //哥布林
{
    public Goblin()
    {
        Basevalue();
    }
    public override void Basevalue()
    {
        Health = 100;
        Defense = 3;
        Level = 1;
        Speed = 3;
        AttackPower = 10;
        Magicpower = 4;
    }
    public int Attack(int Health)                     //普通攻击
    {
        int newAttack = AttackPower + Magicpower;
        return Health - newAttack;
    }
    public int JumpDamage(int Health , int Defense)   //技能:跳劈
    {
        int TheHealth = Health + Defense;
        int newHealth = TheHealth - 15;
        int ThenewHealth = newHealth - Defense;
        return ThenewHealth;
    }
    public int Thrust(int Health , int Defense)       //技能:直刺
    {
        int TheHealth = Health + Defense;
        int newHealth = TheHealth - 18;
        int ThenewHealth = newHealth - Defense;
        return ThenewHealth;
    }
}
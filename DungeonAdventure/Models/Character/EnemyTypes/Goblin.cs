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
    public int JumpDamage(int Health , int Defense)   //技能:跳劈
    {
        int TheHealth = Health + Defense;
        int newHealth = TheHealth - 10;
        return newHealth;
    }
    public int Thrust(int Health , int Defense)       //技能:直刺
    {
        int TheHealth = Health + Defense;
        int newHealth = TheHealth - 15;
        return newHealth;
    }
}
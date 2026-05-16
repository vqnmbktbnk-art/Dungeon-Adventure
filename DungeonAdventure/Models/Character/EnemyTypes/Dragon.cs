public class Dragon : Enemy    //Boss 龙
{
    public Dragon()
    {
        Basevalue();
    }
    public override void Basevalue()
    {
        Health = 200;
        Defense = 30;
        Level = 5;
        Speed = 8;
        AttackPower = 30;
        Magicpower = 28;
    }
    public int FireBall(int Health , int Defense)  //技能:火球攻击
    {
        int TheHealth = Health + Defense;
        int newHealth = TheHealth - 42;
        return newHealth; 
    }
    public int Heal(int Health)
    {
        int newHealth = Health + 10;
        return newHealth;
    }
}
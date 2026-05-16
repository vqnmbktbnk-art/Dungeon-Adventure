public class Enemy : CharacterBase , IDamageAble , IAttackAble
{
    public Enemy()
    {
        Basevalue();
    }
    public virtual void Basevalue()
    {
        Health = 100;
        Defense = 5;
        Level = 1;
        Speed = 2;
        AttackPower = 5;
        Magicpower = 1;
    }
    public int Damage(int Helath , int AttackPower , int Defense)
    {
        int newAttack = AttackPower - Defense;
        this.Health = Helath - newAttack;
        return Health;
    }
    public int Attack(int AttackPower , int Magicpower)
    {
        int newAttackPower = AttackPower + Magicpower;
        return newAttackPower;
    } 
}
public class Warrior : CharacterBase , IDamageAble , IAttackAble //战士
{
    public Warrior()
    {
        Basevalue();    //先完成赋值
    }
    public void Basevalue()
    {
        Health = 100;
        Defense = 30;
        Level = 1;
        Experience = 0;
        Speed = 3;
        AttackPower = 50;
        Magicpower = 13;
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
public class Mage : CharacterBase , IDamageAble , IAttackAble   //法师
{
    public Mage()
    {
        Basevalue();
    }
    public void Basevalue()
    {
        Health = 100;
        Defense = 5;
        Level = 1;
        Experience = 0;
        Speed = 4;
        AttackPower = 15;
        Magicpower = 55;
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
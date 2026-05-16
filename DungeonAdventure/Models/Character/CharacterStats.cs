public interface IDamageAble
{
    int Damage(int Helath , int AttackPower , int Defense);
}
public interface IAttackAble
{
    int Attack(int AttackPower , int Magicpower);
}
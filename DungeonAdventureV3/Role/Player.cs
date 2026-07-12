public class Player : RoleTemplate , IAttackDamage
{
    private const int PlayerHealth = 100;
    private const int PlayerAttack = 10;

    public Player()
    {
       Name = "玩家";
    }

    private int _health = PlayerHealth;
    public override int Health
    {
        get => _health;
        set
        {
            if (value < 0 || value > PlayerHealth) //血量确定在一定范围内
            {
                _health = 0;
            }
            else
            {
                _health = value;
            }
        }
    }

    private int _attack = PlayerAttack;
    public override int Attack
    {
        get => _attack;
        set
        {
            if (value  < 0)  //攻击值不能为负数
            {
                _attack = 0;
            }
            else
            {
                _attack = value;
            }
        }
    }

    private int _level = 1;
    public override int Level
    {
        get => _level;
        set
        {
            if (value < 0)
            {
                _level = 1;
            }
            else
            {
                _level = value;
            }
        }
    }

    public int NormalAttack(int enemyHealth)  //普通攻击
    {
        return enemyHealth - _attack;
    }
}
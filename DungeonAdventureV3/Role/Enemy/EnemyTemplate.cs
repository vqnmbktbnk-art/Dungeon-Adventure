public class EnTemplate : RoleTemplate , IAttackDamage
{
    private int _health;
    public override int Health
    {
        get => _health;
        set
        {
            if (value < 0) //血量确定在一定范围内
            {
                _health = 0;
            }
            else
            {
                _health = value;
            }
        }
    }

    private int _attack;
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

    private int _level;
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

    public virtual int NormalAttack(int playerHealth)
    {
        return playerHealth - _attack;
    }
}
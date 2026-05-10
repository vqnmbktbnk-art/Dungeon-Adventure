public class CharacterBase
{
    private int _health;        //血量
    public int Health
    {
        get => _health;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value) , "血量的初始定义不能小于或等于零");
            }
            else
            {
                _health = value;
            }
        }
    }
    private int _defense;        //防御
    public int Defense
    {
        get => _defense;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value) , "防御的初始定义不能小于或等于零");
            }
            else
            {
                _defense = value;
            }
        }
    }
    private int _level;            //等级
    public int Level
    {
        get => _level;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value) , "等级的初始定义不能小于或等于零");
            }
        }
    }
    private int _experience;       //经验值
    public int Experience
    {
        get => _experience;
        set
        {
            if (value == 0)
            {
                _experience = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value) , "经验值初始定义必须等于零");
            }
        }
    }
    private int _speed;             //速度
    public int Speed
    {
        get => _speed;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value) , "速度初始定义不能小于0");
            }
            else
            {
                _speed = value;
            }
        }
    }
    private int _attackPower;                 //攻击力
    public int AttackPower {get => _attackPower; set => _attackPower = value;}
    private double _magicPower;              //法力
    public double Magicpower
    {
        get => _magicPower;
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(value) , "法力初始定义超出阈值");
            }
            else
            {
                _magicPower = value;
            }
        }
    }
}
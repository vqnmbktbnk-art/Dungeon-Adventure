public class Skill
{
    private int _SkillAttack;
    public int SkillAttack       //技能伤害
    {
        get => _SkillAttack;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value) , "技能的伤害不能小于零");
            }
            else
            {
                _SkillAttack = value;
            }
        }
    }
    private int _CoolingTime;    //冷却时间
    public int CoolingTime
    {
        get => _CoolingTime;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value) , "技能的伤害不能小于零");
            }
            else
            {
                _CoolingTime = value;
            }
        }
    }
}
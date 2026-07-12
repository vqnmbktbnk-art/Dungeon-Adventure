public abstract class RoleTemplate
{
    public string? Name{get; set;}
    public abstract int Health{get; set;}
    public abstract int Attack{get; set;}
    public abstract int Level{get; set;}
}

public interface IAttackDamage
{
    int NormalAttack(int Health);
}
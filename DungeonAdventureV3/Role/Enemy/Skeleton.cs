public class Skeleton : EnTemplate
{
    private const int newAttack = 10;

    public Skeleton()
    {
        Name = "骷髅";
        Health = 50;
        Attack = 5;
        Level = 1;
    }

    public override int NormalAttack(int playerHealth)
    {
        int number = Probability.RandNumber();
        if (number == 3)
        {
            return playerHealth - newAttack;
        }
        return playerHealth - Attack;
    }

    private static class Probability
    {
        public static int RandNumber()
        {
            Random random = new Random();
            int attackValue = random.Next(0,6);
            return attackValue;
        }
    }
}
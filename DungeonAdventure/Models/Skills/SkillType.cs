public interface ICloseRange     //近距离类型
{
    int CloseSkills(int Health);
}
public interface IMagic          //法术类型
{
    int MagicSkills(int Health);
}
public interface IDefense        //防御类型
{
    int DefenseSkills(int Defense);
}
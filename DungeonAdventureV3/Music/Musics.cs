public class SuccessMusic : IMusicTemple
{
    public void MusicPlayback()
    {
        Console.WriteLine("播放成功音效。。，");
        Thread.Sleep(2000);
    }
}
public class FailureMusic : IMusicTemple
{
    public void MusicPlayback()
    {
        Console.WriteLine("播放失败音效。。。");
        Thread.Sleep(2000);
    }
}
public class KillMusic : IMusicTemple
{
    public void MusicPlayback()
    {
        Console.WriteLine("播放击杀怪物音效。。。");
        Thread.Sleep(500);
    }
}
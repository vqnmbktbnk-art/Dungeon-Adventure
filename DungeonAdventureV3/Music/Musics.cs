public class MusicEvent
{
    public MusicEvent()
    {
        MusicEvents();
    }
    SuccessMusic successMusic = new SuccessMusic();
    FailureMusic failureMusic = new FailureMusic();
    KillMusic killMusic = new KillMusic();
    public void MusicEvents()
    {
        EventManager.eventManager.SuccessEvent += successMusic.MusicPlayback;
        EventManager.eventManager.FailEvent += failureMusic.MusicPlayback;
        EventManager.eventManager.KillEvent += killMusic.MusicPlayback;
    }
}
public class SuccessMusic : IMusicTemple
{
    public void MusicPlayback(object? sender , EventArgs e)
    {
        Console.WriteLine("播放成功音效。。，");
        Thread.Sleep(2000);
    }
}
public class FailureMusic : IMusicTemple
{
    public void MusicPlayback(object? sender , EventArgs e)
    {
        Console.WriteLine("播放失败音效。。。");
        Thread.Sleep(2000);
    }
}
public class KillMusic : IMusicTemple
{
    public void MusicPlayback(object? sender , EventArgs e)
    {
        Console.WriteLine("播放击杀怪物音效。。。");
        Thread.Sleep(500);
    }
}
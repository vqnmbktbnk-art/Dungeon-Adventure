public class EventManager
{
    private EventManager(){}

    public static EventManager eventManager{get;} = new EventManager();

    public event EventHandler? SuccessEvent;
    public event EventHandler? FailEvent;
    public event EventHandler? KillEvent;
    public virtual void OnSuccess()
    {
        SuccessEvent?.Invoke(this,EventArgs.Empty);
    }
    public virtual void OnFail()
    {
        FailEvent?.Invoke(this,EventArgs.Empty);
    }
    public virtual void OnKill()
    {
        KillEvent?.Invoke(this,EventArgs.Empty);
    }
    public void OnClearEvent()
    {
        SuccessEvent = null;
        FailEvent = null;
        KillEvent = null;
    }
}
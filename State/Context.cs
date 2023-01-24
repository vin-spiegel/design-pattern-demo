namespace State;

public class Context
{
    // Green, Red
    private State _state;
    
    public Context()
    {
        _state = new GreenLight();
    }

    public void Set(State state)
    {
        _state = state;
    }

    public string Get()
    {
        var res = _state.Get();
        Console.WriteLine(res);
        return res;
    }

    public void Wait()
    {
        _state.Change(this);
    }
}
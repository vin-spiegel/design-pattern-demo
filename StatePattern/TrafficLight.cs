// ReSharper disable CheckNamespace
namespace DesignPatternDemo;

public class TrafficLight
{
    // Green, Red
    private State _state;
    
    public TrafficLight()
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
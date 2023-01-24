// ReSharper disable CheckNamespace
namespace DesignPatternDemo;

public abstract class State
{
    public abstract string Get();

    public virtual void Change(TrafficLight light)
    {
        Console.WriteLine("Wait.. the light changed");
    }
}
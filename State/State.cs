// ReSharper disable CheckNamespace
namespace State;

public abstract class State
{
    public abstract string Get();

    public virtual void Change(Context light)
    {
        Console.WriteLine("Wait.. the light changed");
    }
}
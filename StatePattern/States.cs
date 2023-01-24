// ReSharper disable CheckNamespace
namespace DesignPatternDemo;

internal class GreenLight : State
{
    public override string Get()
    {
        return nameof(GreenLight);
    }

    public override void Change(TrafficLight light)
    {
        base.Change(light);
        light.Set(new RedLight());
    }
}

internal class RedLight : State
{
    public override string Get()
    {
        return nameof(RedLight);
    }

    public override void Change(TrafficLight light)
    {
        base.Change(light);
        light.Set(new GreenLight());
    }
}
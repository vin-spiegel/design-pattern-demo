namespace DesignPatternDemo.Utility;

public static class Utility
{
    public static int Count = 1;
}

public class Template : IDisposable
{
    public Template(string objName)
    {
        Console.WriteLine($"----------------------------");
        Console.WriteLine($"{Utility.Count ++}. {objName}");
        Console.WriteLine($"----------------------------");
    }

    public void Dispose()
    {
        Console.WriteLine($"----------------------------\n");
    }
}
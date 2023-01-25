using DesignPatternDemo.Utility;

namespace Command;

public class Dog
{
    public void Sit()
    {
        Console.WriteLine($"{nameof(Dog)} {nameof(Sit)}");
    }
    
    public void Stay()
    {
        Console.WriteLine($"{nameof(Dog)} {nameof(Stay)}");
    }
}

public class DogCommand : Command
{
    private readonly Dog _dog;
    private readonly string[] _commands;
    
    public DogCommand(Dog dog, string[] commands)
    {
        _dog = dog;
        _commands = commands;
    }
    
    public override void Execute()
    {
        foreach (var c in _commands)
        {
            var command = c.FirstCharToUpper();
            
            if (command.IsNullOrEmpty())
                continue;
            
            var mi = _dog.GetType().GetMethod(command);
            mi?.Invoke(_dog, null);
        }
    }
}
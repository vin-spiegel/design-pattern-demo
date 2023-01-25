namespace Command;

public class Invoker
{
    private readonly List<Command> _commands = new List<Command>();

    public void Add(Command command)
    {
        _commands.Add(command);
    }

    public void Run()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}
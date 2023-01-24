using DesignPatternDemo.Utility;

// state pattern
using (new Template(nameof(State)))
{
    var light = new State.Context();
    light.Get();
    light.Wait();
    light.Get();
}

// command pattern
using (new Template(nameof(Command)))
{
    var myDog = new Command.Dog();
    var dogCommands = new Command.DogCommand(myDog, new[] {"Stay", "sit", "sit" });
    var invoker = new Command.Invoker();
    invoker.Add(dogCommands);
    invoker.Run();
}


using System.Diagnostics;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void State()
    {
        var context = new State.Context();
        var first = context.Get();
        Assert.AreEqual(first, context.Get());
        context.Wait();
        Assert.AreNotEqual(first, context.Get());
    }
    
    [TestMethod]
    public void Command()
    {
        var myDog = new Command.Dog();
        var dogCommands = new Command.DogCommand(myDog, new[] {"Stay", "sit", "sit", "wrong command" });
        var invoker = new Command.Invoker();
        invoker.Add(dogCommands);
        invoker.Run();
    }
}
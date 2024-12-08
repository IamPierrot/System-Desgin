namespace Desgin.Pattern.Behavior;

public interface IPrefixCommand
{
    string Name { get; }
    string Description { get; }
    void Execute();
}

abstract class PrefixCommand(string name, string description) : IPrefixCommand
{
    public string Name { get; } = name;
    public string Description { get; } = description;


    protected void Logger(string message)
    {
        Console.WriteLine(message);
    }

    public abstract void Execute();
}
class CommandHandler
{
    private readonly Dictionary<string, IPrefixCommand> _commands = [];

    public void Register(IPrefixCommand command)
    {
        _commands[command.Name] = command;
    }

    public void Handle(string commandName)
    {
        if (_commands.TryGetValue(commandName, out var command))
        {
            command.Execute();
        }
        else
        {
            Console.WriteLine("Command not found");
        }
    }
}
class HelpCommand : PrefixCommand
{
    public HelpCommand() : base("help", "Show help")
    {
    }

    public override void Execute()
    {
        Console.WriteLine("Help executed");
    }
}

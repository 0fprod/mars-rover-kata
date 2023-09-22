namespace Kata;

public class Commands
{
    public static Command From(string command)
    {
        return command switch
        {
            "f" => new ForwardCommand(),
            "b" => new BackwardCommand(),
            "l" => new LeftCommand(),
            "r" => new RightCommand(),
            _ => throw new ArgumentException($"Unknown command {command}")
        };
    }
}
namespace Kata;

public class Robot
{
    public Position Position { get; private set; }
    public Direction Direction { get; private set; }
    
    public Robot(Position initialPosition, Direction direction)
    {
        Position = initialPosition;
        Direction = direction;
    }

    public void Execute(string[] commands)
    {
        var command = Commands.From(commands[0]);
        switch (command)
        {
            case ForwardCommand:
                MoveForward();
                break;
            case BackwardCommand:
                MoveBackwards();
                break;
            case LeftCommand:
                TurnLeft();
                break;
            default:
                TurnRight();
                break;
        }
    }

    private void TurnRight()
    {
        Direction = Direction.East;
    }

    private void TurnLeft()
    {
        Direction = Direction.West;
    }

    private void MoveBackwards()
    {
        Position = new Position(0, 0);
    }

    private void MoveForward()
    {
        Position = new Position(0, 1);
    }
}
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

    public void Execute(string commands)
    {
        foreach (var command in commands)
        {
            switch (Commands.From(command))
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
        Position = Direction switch
        {
            Direction.North => new Position(Position.X, Position.Y - 1),
            Direction.South => new Position(Position.X, Position.Y + 1),
            Direction.West => new Position(Position.X + 1, Position.Y),
            Direction.East => new Position(Position.X - 1, Position.Y),
            _ => Position
        };
    }

    private void MoveForward()
    {
        Position = Direction switch
        {
            Direction.North => new Position(Position.X, Position.Y + 1),
            Direction.South => new Position(Position.X, Position.Y - 1),
            Direction.West => new Position(Position.X - 1, Position.Y),
            Direction.East => new Position(Position.X + 1, Position.Y),
            _ => Position
        };
    }
}
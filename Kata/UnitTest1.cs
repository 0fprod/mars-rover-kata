namespace Kata;
using FluentAssertions;

public class UnitTest1
{
/*
 * You are given the initial starting point (x,y) of a rover and the direction (N,S,E,W)
 * it is facing.
   The rover receives a character array of commands.
   Implement commands that move the rover forward/backward (f,b).
   Implement commands that turn the rover left/right (l,r).
   Implement wrapping at edges. But be careful, planets are spheres.
   Implement obstacle detection before each move to a new square. 
        If a given sequence of commands encounters an obstacle, 
        the rover moves up to the last possible point, 
        aborts the sequence and reports the obstacle.
 */
    
    [Fact]
    public void Robot_Should_Move_Forward()
    {
        var initialPosition = new Position(0, 0);
        var robot = new Robot(initialPosition, Direction.North);
        
        robot.Execute(new []{"f"});
        
        robot.Position.X.Should().Be(0);
        robot.Position.Y.Should().Be(1);
    }

    [Fact]
    public void Robot_Should_Move_Backwards()
    { ;
        var initialPosition = new Position(0, 1);
        var robot = new Robot(initialPosition, Direction.North);
        
        robot.Execute(new []{"b"});
        
        robot.Position.X.Should().Be(0);
        robot.Position.Y.Should().Be(0);
    }

    [Fact]
    public void Robot_Should_Rotate_Left()
    {
        var initialPosition = new Position(0, 0);
        var robot = new Robot(initialPosition, Direction.North);
        
        robot.Execute(new []{"l"});
        
        robot.Direction.Should().Be(Direction.West);
        robot.Position.X.Should().Be(0);
        robot.Position.Y.Should().Be(0);
    }
    
    [Fact]
    public void Robot_Should_Rotate_Right()
    {
        var initialPosition = new Position(0, 0);
        var robot = new Robot(initialPosition, Direction.North);
        
        robot.Execute(new []{"r"});
        
        robot.Direction.Should().Be(Direction.East);
        robot.Position.X.Should().Be(0);
        robot.Position.Y.Should().Be(0);
    }
    
    [Fact]
    public void Robot_Should_Rotate_Right_And_Move_Forward()
    {
        var initialPosition = new Position(0, 0);
        var robot = new Robot(initialPosition, Direction.North);
        
        robot.Execute(new []{"rf"});
        
        robot.Direction.Should().Be(Direction.East);
        robot.Position.X.Should().Be(1);
        robot.Position.Y.Should().Be(0);
    }
}
using FluentAssertions;

namespace SPV2;

public class RobotShould
{
    // Asumimos que el mapa es 1 x 2 
    // [0,1] 
    // [0,0] 
    [Fact]
    public void ElRobotAvanza()
    {
        var robot = new Robot(new Estado00N());
        
        robot.EjecutarInstrucciones("A");

        robot.Estado.Should().Be(new Estado01N());
    }
    
    [Fact]
    public void ElRobotRetrocede()
    {
        var robot = new Robot(new Estado01N());
        
        robot.EjecutarInstrucciones("R");

        robot.Estado.Should().Be(new Estado00N());
    }
}
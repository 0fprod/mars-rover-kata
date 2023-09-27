using FluentAssertions;

namespace StatePatternMR;

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
   // POSICION X e Y
   // Instrucciones: A(vanzar), R(etroceder), I(zquierda), D(erecha)
   // Direccion: Norte, Sur, Este, Oeste
    [Fact]
    public void Robot_Debe_Avanzar()
    {
        var estadoInicial = new Estado(new Posicion(0, 0), new Norte());
        var estadoFinal = new Estado(new Posicion(0, 1), new Norte());
        var robot = new Robot(estadoInicial);
        
        robot.EjecutarInstrucciones("A");
        
        robot.EnQueEstadoEstas().Should().Be(estadoFinal);
    }
    
    
    [Fact]
    public void Robot_Debe_Retroceder()
    { 
        var estadoInicial = new Estado(new Posicion(0, 1), new Norte());
        var estadoFinal = new Estado(new Posicion(0, 0), new Norte());
        var robot = new Robot(estadoInicial);
        
        robot.EjecutarInstrucciones("R");
        
        robot.EnQueEstadoEstas().Should().Be(estadoFinal);
    }
    
    [Fact]
    public void Robot_Debe_Rotar_A_La_Izquierda()
    {
        var estadoInicial = new Estado(new Posicion(0, 0), new Norte());
        var estadoFinal = new Estado(new Posicion(0, 0), new Oeste());
        var robot = new Robot(estadoInicial);
        
        robot.EjecutarInstrucciones("I");
        
        robot.EnQueEstadoEstas().Should().Be(estadoFinal);
    }
    
    [Fact]
    public void Robot_Debe_Rotar_A_La_Derecha()
    {  
        var estadoInicial = new Estado(new Posicion(0, 0), new Este());
        var estadoFinal = new Estado(new Posicion(0, 0), new Sur());
        var robot = new Robot(estadoInicial);
        
        robot.EjecutarInstrucciones("D");
        
        robot.EnQueEstadoEstas().Should().Be(estadoFinal);
    }
    
    [Fact]
    public void Robot_Debe_Rotar_A_La_Derecha_Y_Avanzar()
    {
        var estadoInicial = new Estado(new Posicion(0, 0), new Norte());
        var estadoFinal = new Estado(new Posicion(1, 0), new Este());
        var robot = new Robot(estadoInicial);
        
        robot.EjecutarInstrucciones("DA");
        
        robot.EnQueEstadoEstas().Should().Be(estadoFinal);
    }

    [Fact]
    public void Robot_Ejecuta_Varias_Instrucciones()
    {
        var estadoInicial = new Estado(new Posicion(0, 0), new Norte());
        var estadoFinal = new Estado(new Posicion(3, 3), new Este());
        var robot = new Robot(estadoInicial);
        
        robot.EjecutarInstrucciones("AADAAADRI");
        
        robot.EnQueEstadoEstas().Should().Be(estadoFinal);
    }
}
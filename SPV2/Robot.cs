namespace SPV2;

public class Robot
{
    public Estado Estado { get; private set; }
    
    public Robot(Estado estado)
    {
        Estado = estado;
    }

    public void EjecutarInstrucciones(string s)
    {
        if (s == "A")
        {
            Estado = Estado.Avanzar();
        } else if (s == "R")
        {
            Estado = Estado.Retroceder();
        }
    }
}
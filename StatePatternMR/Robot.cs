namespace StatePatternMR;

public class Robot
{
    private Estado Estado;
    public Robot(Estado estado)
    {
        Estado = estado;
    }
    
    public Estado EnQueEstadoEstas()
    {
        return Estado;
    }

    public void EjecutarInstrucciones(string instrucciones)
    {
        foreach (var instruccion in instrucciones)
        {
            switch (Instrucciones.Convertir(instruccion))
            {
                case Avanzar:
                    Avanza();
                    break;
                case Retroceder:
                    Retrocede();
                    break;
                case RotarIzquierda:
                    RotaALaIzquierda();
                    break;
                case RotarDerecha:
                    RotaALaDerecha();
                    break;
            }
        }
    }

    private void Avanza()
    {
        var estadoActual = EnQueEstadoEstas();

        Estado = estadoActual.Direccion switch
        {
            Norte => new Estado(estadoActual.Posicion.IncrementarY(), estadoActual.Direccion),
            Sur => new Estado(estadoActual.Posicion.DecrementarY(), estadoActual.Direccion),
            Este => new Estado(estadoActual.Posicion.IncrementarX(), estadoActual.Direccion),
            Oeste => new Estado(estadoActual.Posicion.DecrementarX(), estadoActual.Direccion),
            _ => Estado
        };
    }
    
    private void Retrocede()
    {
        var estadoActual = EnQueEstadoEstas();

        Estado = estadoActual.Direccion switch
        {
            Norte => new Estado(estadoActual.Posicion.DecrementarY(), estadoActual.Direccion),
            Sur => new Estado(estadoActual.Posicion.IncrementarY(), estadoActual.Direccion),
            Este => new Estado(estadoActual.Posicion.DecrementarX(), estadoActual.Direccion),
            Oeste => new Estado(estadoActual.Posicion.IncrementarX(), estadoActual.Direccion),
            _ => Estado
        };
    }

    private void RotaALaIzquierda()
    {
        var estadoActual = EnQueEstadoEstas();
        
        Estado = estadoActual.Direccion switch
        {
            Norte => new Estado(estadoActual.Posicion, new Oeste()),
            Sur => new Estado(estadoActual.Posicion, new Este()),
            Este => new Estado(estadoActual.Posicion, new Norte()),
            Oeste => new Estado(estadoActual.Posicion, new Sur()),
            _ => Estado
        };
    }
    
    private void RotaALaDerecha()
    {
        var estadoActual = EnQueEstadoEstas();
        
        Estado = estadoActual.Direccion switch
        {
            Norte => new Estado(estadoActual.Posicion, new Este()),
            Sur => new Estado(estadoActual.Posicion, new Oeste()),
            Este => new Estado(estadoActual.Posicion, new Sur()),
            Oeste => new Estado(estadoActual.Posicion, new Norte()),
            _ => Estado
        };
    }
    
}
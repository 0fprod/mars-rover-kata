namespace StatePatternMR;

public class Instrucciones
{
    public static Instruccion Convertir(char instruccion)
    {
        return char.ToUpper(instruccion) switch
        {
            'A' => new Avanzar(),
            'R' => new Retroceder(),
            'I' => new RotarIzquierda(),
            'D' => new RotarDerecha()
        };
    }
}

public interface Instruccion
{
}

public class Avanzar: Instruccion {}
public class Retroceder: Instruccion {}
public class RotarIzquierda: Instruccion {}
public class RotarDerecha: Instruccion {}
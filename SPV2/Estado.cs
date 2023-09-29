namespace SPV2;

public interface Estado
{
    Posicion Posicion { get; }
    Direccion Direccion { get; }
    
    Estado Avanzar();
    Estado Retroceder();
    Estado GirarDerecha();
    Estado GirarIzquierda();
}


public class Estado00N : Estado
{
    public Posicion Posicion { get;} = new Posicion00();
    public Direccion Direccion { get; } = new Norte();

    public Estado Avanzar()
    {
        return Direccion switch
        {
            Norte => new Estado01N(),
            Sur => new Estado00S(),
            Este => new Estado00E(),
            Oeste => new Estado00O(),
            _ => new Estado00N()
        };
    }

    public Estado Retroceder()
    {
        return Direccion switch
        {
            Norte => new Estado00N(),
            Sur => new Estado01S(),
            Este => new Estado00O(),
            Oeste => new Estado00E(),
        };
    }
    
    public Estado GirarDerecha()
    {
        return Direccion switch
        {
            Norte => new Estado00E(),
            Sur => new Estado00O(),
            Este => new Estado00S(),
            Oeste => new Estado00N(),
        };
    }
    
    public Estado GirarIzquierda()
    {
        return Direccion switch
        {
            Norte => new Estado00O(),
            Sur => new Estado00E(),
            Este => new Estado00N(),
            Oeste => new Estado00S(),
        };
    }
    
    protected bool Equals(Estado00N other)
    {
        return Posicion.Equals(other.Posicion) && Direccion.Equals(other.Direccion);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Estado00N)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Posicion, Direccion);
    }
}

public class Estado00S : Estado
{
    public Posicion Posicion { get; set; } = new Posicion00();
    public Direccion Direccion { get; } = new Sur();
    public Estado Avanzar()
    {
        throw new NotImplementedException();
    }

    public Estado Retroceder()
    {
        throw new NotImplementedException();
    }

    public Estado GirarDerecha()
    {
        throw new NotImplementedException();
    }

    public Estado GirarIzquierda()
    {
        throw new NotImplementedException();
    }
}

public class Estado00E : Estado
{
    public Posicion Posicion { get; set;} = new Posicion00();
    public Direccion Direccion { get; } = new Este();
    public Estado Avanzar()
    {
        throw new NotImplementedException();
    }

    public Estado Retroceder()
    {
        throw new NotImplementedException();
    }

    public Estado GirarDerecha()
    {
        throw new NotImplementedException();
    }

    public Estado GirarIzquierda()
    {
        throw new NotImplementedException();
    }
}

public class Estado00O : Estado
{
    public Posicion Posicion { get; set;} = new Posicion00();
    public Direccion Direccion { get; } = new Oeste();
    public Estado Avanzar()
    {
        throw new NotImplementedException();
    }

    public Estado Retroceder()
    {
        throw new NotImplementedException();
    }

    public Estado GirarDerecha()
    {
        throw new NotImplementedException();
    }

    public Estado GirarIzquierda()
    {
        throw new NotImplementedException();
    }
}

public class Estado01N : Estado
{
    public Posicion Posicion { get; set;} = new Posicion01();
    public Direccion Direccion { get; } = new Norte();
    public Estado Avanzar()
    {
        throw new NotImplementedException();
    }

    public Estado Retroceder()
    {
        return Direccion switch
        {
            Norte => new Estado00N(),
            Sur => new Estado01S(),
            Este => new Estado01O(),
            Oeste => new Estado01E(),
        };
    }

    public Estado GirarDerecha()
    {
        throw new NotImplementedException();
    }

    public Estado GirarIzquierda()
    {
        throw new NotImplementedException();
    }


    protected bool Equals(Estado01N other)
    {
        return Posicion.Equals(other.Posicion) && Direccion.Equals(other.Direccion);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Estado01N)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Posicion, Direccion);
    }
}

public class Estado01S : Estado
{
    public Posicion Posicion { get; set;} = new Posicion01();
    public Direccion Direccion { get; } = new Sur();
    public Estado Avanzar()
    {
        throw new NotImplementedException();
    }

    public Estado Retroceder()
    {
        throw new NotImplementedException();
    }

    public Estado GirarDerecha()
    {
        throw new NotImplementedException();
    }

    public Estado GirarIzquierda()
    {
        throw new NotImplementedException();
    }
}

public class Estado01E : Estado
{
    public Posicion Posicion { get; set;} = new Posicion01();
    public Direccion Direccion { get; } = new Este();
    public Estado Avanzar()
    {
        throw new NotImplementedException();
    }

    public Estado Retroceder()
    {
        throw new NotImplementedException();
    }

    public Estado GirarDerecha()
    {
        throw new NotImplementedException();
    }

    public Estado GirarIzquierda()
    {
        throw new NotImplementedException();
    }
}

public class Estado01O : Estado
{
    public Posicion Posicion { get; set;} = new Posicion01();
    public Direccion Direccion { get; } = new Oeste();
    public Estado Avanzar()
    {
        throw new NotImplementedException();
    }

    public Estado Retroceder()
    {
        throw new NotImplementedException();
    }

    public Estado GirarDerecha()
    {
        throw new NotImplementedException();
    }

    public Estado GirarIzquierda()
    {
        throw new NotImplementedException();
    }
}


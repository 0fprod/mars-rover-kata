namespace StatePatternMR;

public class Estado
{
    public Posicion Posicion { get; private set; }
    public Direccion Direccion { get; private set; }
    
    public Estado(Posicion initialPosicion, Direccion direccion)
    {
        Posicion = initialPosicion;
        Direccion = direccion;
    }

    protected bool Equals(Estado other)
    {
        return Posicion.Equals(other.Posicion) && Direccion.Equals(other.Direccion);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Estado)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Posicion, Direccion);
    }
}

public class Posicion
{
    public int X { get; }
    public int Y { get; }

    public Posicion(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Posicion IncrementarX()
    {
        return new Posicion(X + 1, Y);
    }
    
    public Posicion IncrementarY()
    {
        return new Posicion(X, Y + 1);
    }
    
    public Posicion DecrementarX()
    {
        return new Posicion(X - 1, Y);
    }
    
    public Posicion DecrementarY()
    {
        return new Posicion(X, Y - 1);
    }
    
    protected bool Equals(Posicion other)
    {
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Posicion)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}

public interface Direccion
{
}

public class Norte : Direccion
{
    protected bool Equals(Norte other)
    {
        if (other is Norte)
        {
            return true; 
        }
        return false;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Norte)obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

public class Sur : Direccion
{
    protected bool Equals(Sur other)
    {
        if (other is Sur)
        {
            return true; 
        }
        return false;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Sur)obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

public class Oeste : Direccion
{
    protected bool Equals(Oeste other)
    {
        if (other is Oeste)
        {
            return true; 
        }
        return false;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Oeste)obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

public class Este : Direccion
{
    protected bool Equals(Este other)
    {
        if (other is Este)
        {
            return true; 
        }
        return false;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Este)obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}


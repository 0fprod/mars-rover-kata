using FluentAssertions;

namespace SPV2;

public class RobotShould
{
    [Fact]
    public void ElRobotAvanza()
    {
        var robot = new Robot(new Estado00N());
        
        robot.EjecutarInstrucciones("A");

        robot.Estado.Should().Be(new Estado01N());
    }
}

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
            Estado = new Estado01N();
        } 
        // for each comando in s
        //  case 'A': 
        //  Estado = Estado.Avanza();
    }
}

public interface Estado
{
    Posicion Posicion { get; }
    Direccion Direccion { get; }
}

public class Estado00N : Estado
{
    public Posicion Posicion { get; set;} = new Posicion00();
    public Direccion Direccion { get; set;} = new Norte();

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
}

public class Estado00E : Estado
{
    public Posicion Posicion { get; set;} = new Posicion00();
    public Direccion Direccion { get; } = new Este();

}

public class Estado00O : Estado
{
    public Posicion Posicion { get; set;} = new Posicion00();
    public Direccion Direccion { get; } = new Oeste();
}

public class Estado01N : Estado
{
    public Posicion Posicion { get; set;} = new Posicion01();
    public Direccion Direccion { get; } = new Norte();


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

}

public class Estado01E : Estado
{
    public Posicion Posicion { get; set;} = new Posicion01();
    public Direccion Direccion { get; } = new Este();

}

public class Estado01O : Estado
{
    public Posicion Posicion { get; set;} = new Posicion01();
    public Direccion Direccion { get; } = new Oeste();
}


public interface Posicion
{
    int X { get; }
    int Y { get; }
}

public class Posicion00 : Posicion
{
    public int X { get; } = 0;
    public int Y { get; } = 0;
}
public class Posicion01 : Posicion
{
    public int X { get; } = 0;
    public int Y { get; } = 1;

    protected bool Equals(Posicion01 other)
    {
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Posicion01)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}

public interface Direccion { }

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


namespace SPV2;

public interface Posicion
{
    int X { get; }
    int Y { get; }
}

public class Posicion00 : Posicion
{
    public int X { get; } = 0;
    public int Y { get; } = 0;

    protected bool Equals(Posicion00 other)
    {
        return X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Posicion00)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
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

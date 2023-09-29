namespace SPV2;

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


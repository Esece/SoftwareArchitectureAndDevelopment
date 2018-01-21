### Value Objects

* Identityless
* Immutable
* Structural Equality

``` csharp
public struct PackageSize : IComparable<PackageSize>
{
    public double Length
    {
        get;
    }

    public double Width
    {
        get;
    }

    public double Height
    {
        get;
    }

    public PackageSize(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    
    public int CompareTo(PackageSize a)
    {
        var thisTotal = Length + Width + Height;
        var aTotal = a.Length + a.Width + a.Height;
        
        return thisTotal.CompareTo(aTotal);
    }
    
    public override int GetHashCode()
    {
        return Length.GetHashCode() ^ Width.GetHashCode() ^ Height.GetHashCode(); 
    }

    public override bool Equals(object obj)
    {
        var size = (PackageSize)obj;
        
        return size.Length == Length && size.Width == Width && size.Height == Height;
    }
}
```

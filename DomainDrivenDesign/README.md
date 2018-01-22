# Domain Driven Design (DDD)

### Value Object (Domain Model)

* Identityless
* Immutable
* Structural Equality

``` csharp
public struct PackageSize : IComparable<PackageSize>
{
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }

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

### Domain Entity (Domain Model)

* Identity Equality
* Behavior-Rich
* Self-Validating
* (Most Likely) Immutable

``` csharp
public class Package
{
    public int Id { get; private set; }
    public string Content { get; private set; }
    public PackageSize Size { get; private set; }
    
    public Package(int id, string content, PackageSize size)
    {
        if (id == 0) throw new ArgumentException(nameof(id));
        if (size.Equals(PackageSize.Empty)) throw new ArgumentException(nameof(size));
        
        Id = id;
        Content = content;
        Size = size;
    }
    
    public InTransitPackage Ship()
    {
        return new InTransitPackage(id, content, size);
    }
    
    public override int GetHashCode()
    {
        return Id.GetHashCode(); 
    }

    public override bool Equals(object obj)
    {
        var shipment = obj as Package;
        if (shipment == null) return false;

        return shipment.Id == Id;
    }
}


### Application Service


### Repository (Persistence)

### Domain Entity

* Identity Equality
* Behavior-Rich
* Self-Validating
* (Most Likely) Immutable

``` csharp
public class Package
{
    public int Id 
    { 
        get; 
        private set; 
    }
    
    public string Content 
    { 
        get; 
        private set; 
    }
    
    public PackageSize Size 
    { 
        get; 
        private set; 
    }
    
    public Package(int id, string content, PackageSize size)
    {
        if (id == 0)
        {
            throw new ArgumentException(nameof(id));   
        }
        
        if (size.Equals(PackageSize.Empty))
        {
            throw new ArgumentException(nameof(size));   
        }
        
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
        
        if (shipment == null)
        {
            return false;   
        }
        
        return shipment.Id == Id;
    }
}
```

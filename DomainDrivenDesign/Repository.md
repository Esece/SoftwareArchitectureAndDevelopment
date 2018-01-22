### Value Objects

* Centralized facade over a backing store (database, XML, SOAP, REST, etc.)

``` csharp
public class ShipmentRepository : IShipmentRepository
{
    IDataContext _dataContext;
    
    public ShipmentRepository(IDataContext dataContext)
    {
        _dataContext = dataContext;
    }
    
    public void Save(IPackage package)
    {
        _dataContext.Add(package);
        _dataContext.SaveChanges();
    }
}
```

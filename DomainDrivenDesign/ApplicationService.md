### Application Service

* Interface Segregated
* Dependencies (i.e. Repository) passed in as interfaces

``` csharp
public class PackageShippingService : IPackageShippingService
{
    IShipmentRepository _shipmentRepository;
    
    public PackageShippingService(IShipmentRepository shipmentRepository)
    {
        _shipmentRepository = shipmentRepository;
    }
    
    public CommandResult Ship(int id)
    {
        var package = _shipmentRepository.GetPackage(id);
        
        try
        {
            var shipment = package.Ship();
            _shipmentRepository.Save(shipment);
            
            return CommandResult.Success(shipment);
        }
        catch (PastPickupCutoffTimeException ex)
        {
            return CommandResult.Failure(package, ex.Code);
        }
    }
}
```

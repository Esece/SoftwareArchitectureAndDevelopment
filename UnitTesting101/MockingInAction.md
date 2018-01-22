### Mocking in Action
with Moq (one of the most widely used mocking framework)

```csharp
using Moq;
:

// Arrange
int id = 123456;
var mockDBContext = new Mock<IDbDataContext>();
mockDBContext.SetUp(c => c.Products).Returns(new[] { new Product { Id = id } });

var service = new PurchaseOrderService(mockDBContext.Object);

// Act
var order = service.GetOrder(id);

// Assert
Assert.IsTrue(order.Id == id);
```
Advantages of Using a Mocking Framework
- Inline implementation (access to variables in method scope)
- No need to set up unused implementation


#### Mocking without a Framework
```csharp
public class FakeDBContext : IDbDataContext
{
    public IEnumerable<Product> Products
    {
        get; set;
    }
    :  
    
    // need to implement all members defined in IDbDataContext
}
```

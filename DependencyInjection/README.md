### Dependency Injection

Regardless of the IoC container, below is the typical process:
1) Register type bindings (Map an interface with a concrete type,
2) Set up any additional setup and a scope (per instance, per requrest, lifetime, etc.), if needed,
3) Resolve the top of the dependency graph with a service locator method,
4) Have the builder crate dependencies automatically.

> Step #3 may be automatically called like the case in ASP.NET.

**Recommended Frameworks (C#)**
* [Autofac](http://autofaccn.readthedocs.io/en/latest/index.html)
* [Ninject](https://github.com/ninject/Ninject)

#### To maximize the benefits of an IoC container, interfaces must be referenced as opposed to implementation:

Typical Setup
``` csharp
public interface IOrderProcessor
{
    :
}

public class OrderProcessor : IOrderProcessor
{
    :
}
```

Interface Segregation
``` csharp
public class OrderService : IOrderService
{
    readonly IOrderProcessor orderProcessor;

    public OrderService(IOrderProcessor orderProcessor)
    {
        _orderProcessor = orderProcessor;
    }
    :
}
```

#### Global configuration should also be injected during setup
Mapping (Autofac example)
``` csharp
var builder = new Autofac.ContainerBuilder();
builder.RegisterType<RepositoryType>().As<IRepositoryType>();
```
AppSettings from web.config (Autofac example)
``` csharp
builder.RegisterType<OrderProcessor>().As<IOrderService>().OnActivating(e =>
{
    e.Instance.Url = ConfigurationManager.AppSettings["Url"];  // OrderProcessor.Url
}
```
> This is also to avoid having to access global objects inside the object.

#### Ask for the top level object and let other objects be created automatically
(Autofac example)
``` csharp
var container = builder.Build();
using (var scope = container.BeginLifetimeScope())
{
    var module = scope.Resolve<IShipper>();
    module.Run();
}
```
> This process is automated with the Autofac MVC integration.

#### Interface segregation helps simplify unit testing greatly
``` csharp
class FakeOrderProcessor : IOrderProcessor
{
    // this is a test double that behaves and returns preset, predictable results..
}
:

var fakeOrderProcessor = new FakeOrderProcessor();
var orderService = new OrderService(fakeOrderProcessor);
// now this orderService implementation can be tested without any external dependency implementation..
```
> It is highly recommended that a mocking framework be used to simplify setup of mocks and stubs.

#### Understand an object lifetime scope carefully and keep objects stateless if at all possible
``` csharp
public class OrderProcessor : IOrderProcessor
{
    int _count;  // Avoid instance variables if the same instance is used by different callers and/or at different times
    :
}
```



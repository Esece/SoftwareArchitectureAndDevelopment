# Anti-Patterns

### Singleton
Making a class manage its own lifetime by ensuring only one global instance is used. In fact, Using a single instance is not an antipattern, but the argument here is where object lifetime is managed.

Typical Singleton Example
``` csharp
public sealed class Singleton
{
    static readonly Singleton _instance = new Singleton();
    public static Singleton Instance { get { return _instance; } }
    Singleton()
    {
        :
    }
}
```

> This is essentially a global variable. The only difference is there is only one public static member as opposed to a static class (with members all static). Globals tend to get in the way of unit testing, where all dependencies should ideally be faked. 

Alternative Solutions
* Dependency injection (Have a container manage object lifetime)
* Abstract factory

``` csharp
builder.RegisterType<SomeClass>().AsSelf().SingleInstance();
```

> **But still think again of why only a single instance should be used. (This may be an XY problem.)**

### Golden Hammer
Basing product development on a particular (often feature-rich third-party) library. Even if the Golden Hammer is a mismatch, very little effort is made to alternative solutions.

Examples
* Developers are so comfortable with this UI library and they even try complicated workarounds to meet requirements, when other vendors offer simple solution to the problem.
* DataTable objects get passed around everywhere in the application because developers find it convenient to retrieve the data this way, even though a simple set of DTO's are more useful,

> **Note that this problem may be not completely solved especially at a base framework level such as WebAPI and WPF**

### Dead End
Modifying a reusable library like jQuery JavaScript code. When subsequent releases of the library become available, modifications will have to be made again. Sometimes the same change may not be able to work because of the vendor's implementation updates.

Alternative Solutions
* Modify your own code
* Copy over the target function/method/classes under a different file name and apply necessary modifications

> **NEVER modify the third-party component source code**

### Lava Flow
Leaving alone old, undocumented code that still seems important and adding new code on top of it to sometimes work around issues that might exist. The previous code stays because no ones wants to mess with it.

Alternative Solutions
* Work with business stakeholders to understand requirements and rewrite code
* Remove code and run tests (If tests pass, the code should have been removed.)

> **This is often due to lack of requirement documentation, and the code has become the documentation instead.**


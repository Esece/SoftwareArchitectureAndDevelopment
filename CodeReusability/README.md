# Code Reusability
Avoid code duplication and reuse as much existing code as possible. Generally the less code you write, the less you maintain.

## Types of Reusability
* Reusable Libraries (Assembly-Level)
* Generic Types and Methods (Runtime or Compile-Time Level)

## Reusable Libraries
* Standard Libraries (Best)
  - Part of the Framework
  - Separately Downloadable (Free)
* Third-Party
  - Free
  - Paid
  - Open Source
* In-House
  - Core libraries (utilities, adapters, etc.)

### In .NET Framework, 'System' namespace should be your first place for reusable code

Simple example of getting html from a website
``` csharp
var html = new System.Net.WebClient().Download("https://www.google.com");
```
Enums can also be reusable
``` csharp
public enum HttpStatusCode
{
    HttpStatusCode.OK = 200,
    :
}
```

### Reasons for using third-party libraries

* The standard libraries do not offer necessary functionality

Selection Criteria
  * Used by the existing framework vendors (Best)
  * Popularity
  * Open Source
  * Cost

> One of framework vendor-based libraries is Newtonsoft.Json in MVC/WebApi. Other popular libraries are jQuery and AngularJS for JavaScript.

## Generic Types and Methods
* C# Generic Types and Methods
  - Classes in System.Collections.Generic namespace
  - LINQ extension methods
* Runtime Assembly Code Generation
  - C# Expression API
  - IL (Intermediate Language) Generation
  
### C# generic types are a form of code reuse at JIT compile time
``` csharp
public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
```
> Physically different classes are created in memory.

### A simple custom generic method
``` csharp
public static class IListExtensions
{
    static Random Random = new Random();
    public static IList<T> Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
        return list;
    }
}
```

### Runtime Assembly Code Generation
An Example of a reusable 'Value Type' base class in DDD. (Performance of generated code is equivalent of that of hand-written code, which is an order of magnitude faster than Reflection-based implementation.
``` csharp
// Part of the code is omitted
public abstract class ValueObject
{
    static readonly Dictionary<Type, Func<object, int>> GetHashCodeInternals = new Dictionary<Type, Func<object, int>>();
    static readonly object _syncLock = new object();
    :
    
    public override int GetHashCode()
    {
        var type = GetType();
        Func<object, int> func;

        if (!GetHashCodeInternals.TryGetValue(type, out func))
        {
            var param_obj = Expression.Parameter(typeof(object));
            var var_t = Expression.Variable(type);
            var var_hashcode = Expression.Variable(typeof(int));
            var lines = new List<Expression>();

            lines.Add(Expression.Assign(var_t, Expression.Convert(param_obj, type)));

            foreach (var prop in type.GetProperties())
            {
                Expression arg1 = Expression.Property(var_t, prop.Name);
                Expression exp = Expression.Assign(var_hashcode, Expression.ExclusiveOr(var_hashcode, Expression.Call(arg1, prop.PropertyType.GetMethod("GetHashCode"))));

                if (!prop.PropertyType.IsValueType)
                {
                    exp = Expression.IfThen(Expression.NotEqual(arg1, Expression.Constant(null)), exp);
                }

                lines.Add(exp);
            }

            lines.Add(var_hashcode);

            func = Expression.Lambda<Func<object, int>>(Expression.Block(new[] { var_t, var_hashcode }, lines), param_obj).Compile();

            lock (_syncLock)
            {
                GetHashCodeInternals[type] = func;
            }
        }

        return func(this);
    }
}
```

> Runtime code generation is a complex topic. Also see [Data-Driven Programming](https://github.com/Esece/SoftwareArchitectureAndDevelopment/tree/master/DataDrivenProgramming) for details.



## Data-Driven Programming
Somewhat loosely defined, data-driven programming is about generating different output from a set command. 
### Simple Example
Lookup Function
``` csharp
static string GetStateCode(string state)
{
    if (StateLookup.ContainsKey(state))
    {
        return StateLookup[state];
    }
    else
    {
        return null;
    }
}

static Dictionary<string, string> StateLookup =...
```
> The GetStateCode function is the command, and the StateLookup object is the data. Furthermore, the Dictionary<,> class is also the commands and the pairs of strings are the data.

**Non-Data-Driven Function**
``` csharp
static string GetStateCode(string state)
{
    if (state == "California")
    {
        return "CA";
    }
    else if (state == "Washington")
    {
        return "WA";
    }
    :
    
    else
    {
        return null;
    }
}
```
> For changes, you will need go through the commands. "Code changes" need recompiling.

### Why Prefer Data to Logic?

#### Advantages of Using Data
* Maintenance
* Storage
* Transmission

### Generics in .NET is a type of data-driven programming
LINQ Query (Projection) and Array Builder
``` csharp
var data;
:

var names = data.Select(d => d.Name).ToArray();
```
> Data-driven programing separates general-purpose, reusable logic from data, otherwise reducing repetitive code.

### "Logic" can also become "Data"
**Let input data create a command with .NET Expression**
Generate necessary code on demand (Mapping a value by a string key)
``` csharp
static void MapValue<T>(T object, string key, string value)
{
    var t = Expression.Parameter(typeof(T));
    var assign = Expression.Assign(Expression.Property(t, key), Expression.Constant(value));
    var action = Expression.Lambda<Action<Address>>(assign, t).Compile();
    action(object);
}
```

> The compiled expression is an instruction set in IL. Thus, the performance is equivalent of writing code as "person.Name = "Mike";" 

However, it's not effective without caching the generated code
``` csharp
static void MapValue<T>(T object, string key, string value)
{
    var action = Cache.Get(typeof(T), key);

    if (action == null)
    {
        :  // generate code
        Cache.Save(typeof(T), key, action)
    }
    
    action(object);
}
```

> **The property value assignment logic is "data."**

Reflection can be used for the same purpose, but it comes at a cost.
``` csharp
static void MapValue<T>(T object, string key, string value)
{
    typeof(T).GetProperty(key).SetValue(object, value);
}
```

> In the above example, "GetProperty" results can be cached but "SetValue" is still very expensive to execute. 

> **DO USE reflection for simplicity if the performance is acceptable to your requirements.**


### It's NOT database-driven programming!
> Not to be confused, its focus is not on developing a database-backed application.



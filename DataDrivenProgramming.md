## Data-Driven Programming
Somewhat loosely defined, data-driven programming is about generating different output from a static set of commands. 
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
> The GetStateCode function is the commands, and the StateLookup object is the data. Furthermore, the Dictionary<,> class is also the commands and the pairs of strings are the data.

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

#### Benefits of Using Data
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

### It's NOT database-driven programming!
Not to be confused, its focus is not on developing a database-backed application.

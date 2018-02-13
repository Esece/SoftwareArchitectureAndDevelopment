## Replacing Type Lookup (Dictionary) with Generic Class (C#)

#### A dictionary with Type as a key can be replaced with a generic class.

If you have this:
``` csharp
// definition
static Dictionary<Type, string> TypeDescriptions;
:

// usage
if (!TypeDescriptions.ContainsKey(typeof(T)))
{
    TypeDescriptions.Add(typeof(T), value);
}

var description = TypeDescriptions[typeof(T)];
```

You can replace with this:
``` csharp
// definition
class TypeDescription<T>
{
    static readonly T string Value;
}

// usage
static TypeDescription<T> TypeDescription;
:

if (TypeDescription<T>.Value == 0)
{
    TypeDescription<T>.Value = value;
}

var description = TypeDescription<T>.Value;
```

> You must have a Type variable (T).

## LINQ Extensions Design Guidelines

### Throw on Empty Collection
This is the exception used in the standard library for empty collection
``` csharp
throw new InvalidOperationException("Sequence contains no elements")  
```

### Loop the Collection Only Once
Store previous items if necessary
``` csharp
T previous = default(T);

foreach (T item in source)
{
    if (previous < item)
    {
        previous = item;
    }
    :
}
:

```

### Exit as Early as Possible
If the result is known before the last element, exit.
``` csharp
foreach (T item in source)
{
    if (predicate(item))
    {
        return false;
    }
    :
}
:

```

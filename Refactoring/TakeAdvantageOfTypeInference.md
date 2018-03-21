## Take Advantage of Type Inference 

Purposes:
* Less typing
* Reusable code
* Built-in feature

-----

An example of a long type name
``` csharp
var queries = new[]
{
    context.tblItem.Where(i => i.Number < 100),
    context.tblItem.Where(i => i.Code > 500)
};

var stack = new Stack<IEnumerable<IQueryable<tblItem>>>(queries);  // need to specify the type..
```

With a simple extension method, there is no need to spell out the type
``` csharp
var queries = new[]
{
    context.tblItem.Where(i => i.Number < 100),
    context.tblItem.Where(i => i.Code > 500)
};

var stack = queries.ToStack();  // simpler now..
:

public static Stack<T> ToStack<T>(this IEnumerable<T> source)
{
    return new Stack<T>(source);
} 
```

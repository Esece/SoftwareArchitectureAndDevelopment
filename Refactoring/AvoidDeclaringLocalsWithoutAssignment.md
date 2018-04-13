## Avoid Declaring Local Variables with Default Values

Purposes:
* Variables placed closer to where they are used
* Fewer lines
* Simpler scoping
* Use of 'var'

-----

Separate lines for declaration and first assignment 
``` csharp
DataTable tbl;

if (id != Guid.Empty)
{
    tbl = Dal.Get(id);
}
else
{
    return null;
}
```

Refactored
``` csharp
if (id == Guid.Empty)
{
    return null;
}

var tbl = Dal.Get(id);
```
> In general, local variables should be declared as close to where they are used as possible. Doing so will help you manage fewer locals and simplify code and debugging.

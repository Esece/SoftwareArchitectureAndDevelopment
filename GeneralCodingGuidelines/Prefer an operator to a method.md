### Prefer an operator to a method for primitives and string

Avoid:
``` csharp
if (StatusCode.Equals("OK"))
{
    :
}
```

Prefer:
``` csharp
if (StatusCode == "OK")
{
    :
}
```

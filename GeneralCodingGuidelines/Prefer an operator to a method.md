### Prefer an operator to a method

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

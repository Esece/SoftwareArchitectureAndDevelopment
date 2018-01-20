### Prefer UTC date to local date

If the application stores date values, save and operate as UTC date and convert on client side using a timezone offset

Avoid:
``` csharp
var time = DateTime.Now;
```

Prefer:
``` csharp
var time = DateTime.UtcNow;
```

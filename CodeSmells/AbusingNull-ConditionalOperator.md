## Abusing Null-Conditional Operator

> One of the purposes of using the operator is to improve readability..

Seems a bit cryptic:
``` csharp
if (!(rules?.Any()).GetValueOrDefault())
      return null;
```

Compared to:
``` csharp
if (rules == null || !rules.Any())
      return null;
```

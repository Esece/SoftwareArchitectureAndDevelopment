# General Coding Guidelines

### One variable declaration per line

Avoid:
``` csharp
int width, height;
```

Prefer:
``` csharp
int width;
int height;
```

### Prefer LINQ to a simple loop

Avoid:
``` csharp
var errorMessages = new List<string>();

foreach (var notification in notifications)
{
    errorMessages.Add("Response: " + notification.Message);
}

response.Errors = errorMessages.ToArray()
```

Prefer:
``` csharp
response.Errors = notifications.Select(n => "Response: " + n.Message).ToArray();
```

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

### Define the most likely condition first

``` csharp
if (a < 0)
{
    // this condition is more expected..
}
else if (a > 10)
{
   // this condition is less expected..
}
```
  
### Place return statements and non-return statements in separate conditionals

Avoid:
``` csharp
if (a == 0)
{
    return false;  // also applies to 'throw', 'break', and 'continue'
}
else if (a < 10)
{
    // some statement..
}
else
{
    // some statement..
}
```

Prefer:
``` csharp
if (a == 0)
{
    return false;
}

if (a < 10)
{
    // somestatement..
}
else
{
    // some statement..
}
```

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

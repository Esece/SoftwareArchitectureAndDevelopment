# General Coding Guidelines

### One variable declaration per line
``` csharp
// AVOID
int width, height;


// PREFER
int width;
int height;
```

### Prefer LINQ to a simple loop
``` csharp
// AVOID
var errorMessages = new List<string>();
foreach (var notification in notifications)
{
    errorMessages.Add("Response: " + notification.Message);
}
response.Errors = errorMessages.ToArray()


// PREFER
response.Errors = notifications.Select(n => "Response: " + n.Message).ToArray();
```

### Prefer an operator over a method for primitives and string
``` csharp
// AVOID
if (StatusCode.Equals("OK"))
{
    :
}


// PREFER
if (StatusCode == "OK")
{
    :
}
```

### Define the most likely condition first
``` csharp
// PREFER
if (a < 0)
{
    // this condition is more expected..
}
else if (a > 10)
{
   // this condition is less expected..
}
```

### Prefer UTC date to local date
If the application stores date values, save and operate as UTC date and convert on client side using a timezone offset
``` csharp
// AVOID
var time = DateTime.Now;


// PREFER
var time = DateTime.UtcNow;
```

### Use 'readonly' instead of 'const' for public members
'const' requires the caller assembly be recompiled for any changes
``` csharp
// DO NOT DO THIS
public const string Name = "Box";

// DO THIS INSTEAD
public readonly string Name = "Box";
```

### Place return statements and non-return statements in separate conditionals
``` csharp
// AVOID
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


// PREFER
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

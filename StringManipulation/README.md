## String Manipulation (C#)

### Basic Rules
* Use simple, easy-to-read methods first
* Use Regular Expressions sparingly
* Profile and set performance goals only if string manipulation is a large part of an application performance issue.

### Do not be too obssessed with StringBuilder
``` csharp
var sb = new StringBuilder();
sb.Append(firstName);
sb.Append(" ");
sb.Append(lastName);
var fullname = sb.ToString();
```
``` csharp
var fullname = firstName + " " + lastName;  // this is fine.
```

If you happen to have the values in a collection, below is fine as well
``` csharp
string[] names;
:

var fullname = String.Join(" ", names);  // simple and readable
```

### Comparing two strings case-insensitively (There are many ways to accomplish.)
The most straight-forward approach
``` csharp
if (String.Equals(name1, name2, StringComparison.OrdinalIgnoreCase))  // also null-safe
{
    :
```

Another approach
``` csharp
if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))  // this is not null safe if name1 can be null.
{
    :
```

Case-Insensitive Key Lookup (Dictionary)
``` csharp
var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
```

Avoid
``` csharp
if (name1.ToLower() == name2.ToLower())
{
    :
```

### Regular Expressions makes validation simpler
``` csharp
static bool IsValidZipcode(string value)
{
    return Regex.IsMatch(value, @"^\d{5}(|-\d{4})$");
}
```
> Another advantage of using Regex is patterns can be managed as configuration values.

### Performance optimization may be needed for high traffic
In one machine, the previous Regex method takes '30 ticks' in average
``` csharp
Regex.IsMatch(value, @"^\d{5}(|-\d{4})$")
```

Whereas the optimized implementation below can perform in 1 tick in the same machine.
``` csharp
static bool IsValid(string value)
{
    if (value.Length == 5)
    {
        return IsNumber(value[0]) && IsNumber(value[1]) && IsNumber(value[2])  && IsNumber(value[3]) && IsNumber(value[4]);
    }
    else if (value.Length == 10)
    {
        return IsNumber(value[0]) && IsNumber(value[1]) && IsNumber(value[2])  && IsNumber(value[3]) && IsNumber(value[4])
            && value[5] == '-' && IsNumber(value[6]) && IsNumber(value[7])  && IsNumber(value[8]) && IsNumber(value[9]);
    }
    
    return false;
}

static bool IsNumber(char c)
{
    return (c <= '0' && c <= '9');
}
```

> Optimization often makes code more complex. It is best considered when the entire process is completed and when you can still afford to revisit it for further analysis.





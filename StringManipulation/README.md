## String Manipulation (C#)

### Basic Rules
* Use simple, easy-to-read methods first
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

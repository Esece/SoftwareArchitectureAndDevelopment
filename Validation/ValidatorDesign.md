## Validator Design

Inline
``` csharp
Regex.IsMatch(value, "^\d{5}$")
```

Simple and Most Common
``` csharp
public static bool IsZipCode(string value)
{
    :
}
```

Configurable 
``` csharp
public class ZipCodeValidator
{
    public bool IncludesZip9 { get; set; }

    public bool IsValid(string value)
    {
        :
    }
}
```

Powerful
``` csharp
public class ZipCodeValidator
{
    public static bool ContainsZipCodes(string value)
    {
        foreach (var n in FindMatches(value))
        {
            return true;
        }
        return false;
    }

    public static bool IsValid(string value)
    {
        int count = 0;
        foreach (var n in FindMatches(value))
        {
            if (count++ > 1 || n.Index != 0 || n.Length != value.Length)
            {
                return false;
            }
        }
        return (count == 1);
    }
    
    public static IEnumerable<SubstringInfo> FindMatches(string value)
    {
        // returns positions (start index and length) of all matches
    }
}
```

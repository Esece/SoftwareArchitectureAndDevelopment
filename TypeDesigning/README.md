# Type Designing

### Data Transfer
- Flat structure
- Primitive types
- No methods
- Parameterless constructor
- Modifiable
- Serializable

``` csharp
class Item
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public double Price { get; set; }
    public string CurrencyCode { get; set; }
}
```

### Immutable
- Value equality
- Identityless
- Flat structure
- Immutable

``` csharp
struct Dimension
{
    public int Width { get; private set; }
    public int Length { get; private set; }
    public int Height { get; private set; }
    
    public Dimension(int width, int length, int height)
    {
        Width = width;
        Length = length;
        Height = height;
    }
}
```

### Enumeration
- Named integer constants
- (Often) Type-safe

``` csharp
enum ListOrder
{
    Ascending,
    Descending,
}
```

### Constant Class
- Behaves like an emum but is much richer
- No public constructors
- Immutable

``` csharp
class CurrencyCode
{
    public static readonly CurrencyCode Usd = new CurrencyCode { Code = "USD", Name = "US Dollar", Symbol = "$" };
    public static readonly CurrencyCode Gbp = new CurrencyCode { Code = "GBP", Name = "British Pound", Symbol = "£" };

    public string Code { get; private set; }
    public string Name { get; private set; }
    public string Symbol { get; private set; }

    private CurrencyCode() { }
}
```

### Microtype
- Validation-Rich
- Can be easily replaced with a primitive type
- Sometimes used to clarify parameters

``` csharp
class EmailAddress
{
    string _emailAddress;
    
    public EmailAddress(string emailAddress)
    {
        if (Regex.IsMatch(emailAddress, @"^.*?@.*?\..*?$"))
        {
            throw new ArgumentException();   
        }
        
        _emailAddress = emailAddress;
    }
    
    public static implicit operator string (EmailAddress emailAddress)
    {
        return emailAddress._emailAddress;
    }
    
    public static implicit operator EmailAddress (string emailAddress)
    {
        return new EmailAddress(emailAddress);
    }
}
```



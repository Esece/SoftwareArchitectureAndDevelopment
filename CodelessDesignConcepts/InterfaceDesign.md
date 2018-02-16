# Interface Design

### Keep it Simple
#### Use the following types for publicly exposed objects
- int
- double
- decimal
- bool
- char
- byte
- DateTime
- string
- enum
- object
- dynamic

**Also**
- Array or List of one of the above types
- Dictionary with the above types
- Custom class with the above types

### Empty or Default Object for Immutable Types
``` csharp
public static readonly Price Empty = new Price();
```

Use one of the following names:
- Empty
- Default
- Unknown
- Unspecified

> Make it 'public static readonly.'

Set up a private parameterless constructor
``` csharp
class Price
{
    :
    private Price() { }
    :
}
```

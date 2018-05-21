## Common Coding Patterns



### Zero Means Max
##### Simplifying the object setup
``` csharp
public int Timeout { get; set; }
:

public void Execute()
{
    int timeout = (Timeout > 0 ? Timeout : int.MaxValue);
    :
```

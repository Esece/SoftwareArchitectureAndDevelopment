## Enum with Annotation Attributes

Enum becoming like a class with members
``` csharp
enum Status
{
    [Display(Name="Active status")]
    Active = 1,
    [Display(Name = "Deactive status")]
    Deactive = 2,
    [Display(Name = "Pending status")]
    Pending = 3
}
```

Notes:
* May be required for some GUI frameworks, but doing so will make the 'data' couple to the UI frameworks. (Less reusable)
* The annotation data members are difficult to discover (no intellisense support, invisible in the debugger) and require outside setup to read (commonly via reflection). 

-----

### An alternative, more flexible solution
``` csharp
class Status
{
    public static readonly Status Unknown = new Status { Value = 0, DisplayName = "" };
    public static readonly Status Active = new Status { Value = 1, DisplayName = "Active status" };
    public static readonly Status Deactive = new Status { Value = 2, DisplayName = "Deactive status" };
    public static readonly Status Pending = new Status { Value = 3, DisplayName = "Pending status" };

    public int Value { get; private set; }
    public string DisplayName { get; private set; }
    
    static IDictionary<int, Status> AllStatuses = typeof(Status).GetFields(BindingFlags.Public | BindingFlags.Static).ToDictionary(s => ((Status)s.GetValue(null)).Value, s => (Status)s.GetValue(null));

    private Status() { }
    
    
    // if you want the enum-like conversion (enum to int)
    public static implicit operator int(Status status)
    {
        return status.Value;   
    }
    
    // if you want the enum-like conversion (int to enum)
    public static implicit operator Status(int status)
    {
        return AllStatuses.ContainsKey(status) ? AllStatuses[status] : Unknown;
    }
}
```

> This class setup will still have a maintenance issue as adding a new entry requires a source code change.



## Reuse Enums from the Standard Libraries

Try searching the standard libraries for reuse before creating your own
``` csharp
namespace System.ComponentModel
{
    public enum ListSortDirection
    {
        Ascending,
        Descending
    }
}
```

Avoid
``` csharp
namespace Esece
{
    public enum SortOrder
    {
        Ascending,
        Descending
    }
}
```

> Limit to the common libraries such as System.dll and System.Core.dll, which are included in project templates by default. 

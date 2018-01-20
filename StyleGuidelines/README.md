
# Style Guidlines
Simple C# guidlines to simplify development and maintenance

### Goals
- Consistency (Use the same conventions as standard libraries)
- Discoverability (Easy to find keywords in Intellisense)
- Readability (Facilitate maintaining code)

### Casing
|Type|Casing|Examples|
|----|------|--------|
|Namespace|Pascal case|AdvancedTech.ShippingPro|
|Class|Pascal case|OrderProcessor, MTCalculator|
|Method|Pascal case|Validate()|
|Property|Pascal case|FullName|
|Field (private)|Camel case with underscore prefix|_firstName|
|Field (non-private)|Pascal case|DefaultTimeOut|
|Local variable|Camel case|orderStatus|

### Formatting
``` csharp
namespace AdvancedTech
{
    public class Order  // 4 spaces per tab 
    {
        :
    }
}
```

``` csharp
public string Text 
{ 
    get; 
    set;  // A breakpoint can be easily set to the setter
}
```

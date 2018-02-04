
# Style Guidlines
Simple C# coding style guidlines to simplify development and maintenance

### Goals
- Consistency (Use the same conventions as standard libraries)
- Discoverability (Easy to find keywords in Intellisense)
- Readability (Facilitate maintaining code)
- Clarity (Avoid any ambiguation)

### Casing
|Type|Casing|Examples|
|----|------|--------|
|Namespace|Pascal case|AdvancedTech.ShippingPro|
|Class|Pascal case|OrderProcessor, MTCalculator|
|Method|Pascal case|Validate()|
|Property|Pascal case|FullName|
|Field (private)*|Camel case with underscore prefix|_firstName|
|Field (non-private)|Pascal case|DefaultTimeOut|
|Local variable*|Camel case|orderStatus|

**The casing for private members and locals do not need to be very strict as long as they are distinct and consistent.**
``` csharp
// THIS IS OK
public class Processor
{
    string m_name;  // 'm_' prefix
    :
    
    public Processor(string name)
    {
        :
```

### Formatting
Curly braces have their own lines
``` csharp
if (!exists)
{
    :
```
4 spaces per indent(tab)
``` csharp
namespace AdvancedTech
{
    public class Order  // 4 spaces per tab 
    {
        :
    }
}
```
Disambiguate breakpoints
``` csharp
public string Text 
{ 
    get; 
    set;  // A breakpoint can be easily set to the setter
}
```

### Access Modifiers
Omit 'internal' for classes
``` csharp
class EmailFinder
{
    :
```

Omit 'private' for fields and nested classes
``` csharp
string _text;  // private field
```


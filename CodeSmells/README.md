# Code Smells
Legal but controversial, if not bad, coding practices that can adversely affect readability, maintainability and bug fixing. Not all of the examples need immediate correction, so they are more of subject matters upon reviewing code.

### Unnecessary Maintenance

The length and the values must be in sync when only the value can change:
``` csharp
var numbers = new int[3] { 100, 200, 300 };  // length can be inferred.
```

There is no need to check the collection item count before an iterator:
``` csharp
if (books.Count > 0)  // if anything, check for null...
{
    foreach (var book in books)
    {
        basket.Add(book);
    }
}
```

### Misuse
The ref keyword is not needed:
``` csharp
void Process(ref Order order)
{
    // there is no reassignment to 'order' inside this method..
    int result = Send(order.Number, order.Item, order.Quantity);
    order.Status = (OrderStatus)result;
}
```

[//]: # (### Wrong Places)
[//]: # (### Default Value Obsession)
### Regions
Regions can be useful for auto-generated code but can easily lead to a maintenance disaster by encouraging unstructured, disorganized code
``` csharp
#region Namespaces
:
#endregion

class ProfileService
{
    #region Properties
    :
    #endregion
    #region Constructors
    :
    #endregion
    #region Public Methods
    :
    #endregion
    #region Private Methods
    string[] GetAddressValidationErrors(MailAddress address)
    {
        #region Check Format
        :
        #endregion
        #region Check Country
        :
        #endregion
        #region Check Region/Postal Code
        :
        #endregion
    }
    #endregion
}
```

### Garbage
Always true:
```
activities = activities.OrderByDescending(a => a.Time);

if (activities != null)  // this is never null...
{
    :
}
```

Neglect to clean up:
```
model.Comment == null ? null : model.Comment;  // this line has no value
```

Not understanding the default values (The constructor below can be removed completely.)
```
class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Value()
    {
        X = 0;  // no need to initialize int to zero..
        Y = 0;
    }
}
```


### Naming Inconsistency
C# Language typically uses pascal-cased namees for properties:
``` csharp
agent.name = "New York";  // 'name' should be 'Name'
```

### out Parameters with void Return Type 
Create a class or a struct to return instead:
``` csharp
void GetLocation(string zipCode, out string city, out string state)
{
    :
}
```

### Overcomplicated Conditionals
Too many operators
```
if (!(textBox.Text == null))  // it's simply '!= null'
{
    :
}
```

### Verbose Style
```
if (sent)
{
    return true;
}
else
{
    return false;
}
```

### Reinventing the Wheel
Same as 'month.PadLeft(2, '0')'
```
if (month.Length == 1)
{
    month = "0" + month;
}
```

### Variable Reuse for Different Purposes
```
var breakfast = GetBreakfast();
if (breakfast != null)
{
    :
}

breakfast = GetDinner();
if (breakfast != null)
{
    :  // 'breakfast' here actually mean dinner..
}
```

### Type Checking in a Conditional Statement
### Frequent or Repeated Casting
### Switch Statements

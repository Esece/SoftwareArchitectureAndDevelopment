# Generic Types and Methods (C#)

### A Solution to Implementation Reuse
Sample Method
``` csharp
T Max<T>(T first, T[] values) where T : IComparable
{
    T maximum = first;
    foreach (T item in values)
    {
        if (item.CompareTo(maximum) > 0)
        {
            maximum = item;
        }
    }
    return maximum;
}
```
**At runtime, a method is generated for each Type**

In the case of having the following calls:
``` csharp
int max = Max(a, b);
double max = Max(y, z);
```
Two separate methods are generated. 
```csharp
int Max(int first, int[] values)
{
    int maximum = first;
    foreach (int item in values)
    {
        if (item.CompareTo(maximum) > 0)
        {
            maximum = item;
        }
    }
    return maximum;
}

double Max(double first, double[] values)
{
    double maximum = first;
    foreach (double item in values)
    {
        if (item.CompareTo(maximum) > 0)
        {
            maximum = item;
        }
    }
    return maximum;
}
```

> You can confirm this by checking the meta data for the two methods.

> Technically speaking, more types you use for a generic type or method, more memory is consumed.

**Since two physically separate versions exist, static members in a generic type also exist separately**

``` csharp
class SmartList<T>
{
    public static int Counter = 0;
    :
    
    public SmartList<T>()
    {
        Counter++;
    }
    :
}

var a = new SmartList<int>();
var b = new SmartList<double>();

Console.WriteLine(b.Counter);  // prints '1'
```


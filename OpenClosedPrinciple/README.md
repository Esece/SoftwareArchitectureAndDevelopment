## Open/Closed Priciple

From Wikipedia:
> **In object-oriented programming, the open/closed principle states "software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification";[1] that is, such an entity can allow its behaviour to be extended without modifying its source code.**

#### Pattern 1 (Separation of Data and Implementation)

Violation Example (In order to support new operators, the existing code must be altered by adding new conditions.)
``` csharp
if (b.operator == "GreaterThan")
{
    results.Add(a < b);
}
else if (b.operator == "LessThan")
{
    results.Add(a > b);
}
```

Following the Principle (Program by Data)
``` csharp
// changes are made within this isolated scope
class Evaluator
{
    static Dictionary<string, Func<A, B, bool>> Evaluators = new Dictionary<string, Func<A, B, bool>>
    {
        { "GreaterThan", (a, b) => a < b },
        { "LessThan", (a, b) => a > b },
    };
    
    static bool IsMatch(A a, string operator, B b)
    {
        return Evaluators[operator](a, b);
    }
}

:
results.Add(Evaluator.IsMatch(a, operator, b));  // no change needed here to support enhancements
```


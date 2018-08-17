## Coding Patterns (C#)
Pros, Cons, Usage, Antipattern


**Inline Conditional Method Invocation with Assignment**
``` csharp
var result = conditional ? MethodA() : MethodB();
```
|Pros|Cons|Usage|Anti-Pattern?|
|-----|-----|-----|-----|
|A one-liner. Clean as long as a conditional is kept simple and short|Can be difficult to read if the statement is long.||Maybe. Methods may be polymorphically called.|

**Variable Declaration & Conditional Method Invocation**
``` csharp
Result result;
if (conditional)
{
    result = MethodA();	
}
else
{
    result = MethodB();	
}
```
|Pros|Cons|Usage|Anti-Pattern?|
|-----|-----|-----|-----|
|Easy to read and follow|Declaration is separated from initialization/assignment. The assignment operation is duplicated. |Avoid in a long method.||

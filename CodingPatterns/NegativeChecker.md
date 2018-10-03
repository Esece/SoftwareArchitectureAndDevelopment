## Negative Checker


``` csharp
public static bool IsNotNullOrEmpty(this string input)
{
    return !String.IsNullOrEmpty(input);
}
```
|Pros|Cons|Usage|Anti-Pattern?|
|-----|-----|-----|-----|
|More concise than using the negation operator (!), convenient in the functional paradigm|Could force you to add more negative checkers (more code)|Complex conditionals|Maybe|

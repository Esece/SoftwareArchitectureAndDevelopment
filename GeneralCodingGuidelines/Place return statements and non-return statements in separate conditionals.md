### Place return statements and non-return statements in separate conditionals

Avoid:
``` csharp
if (a == 0)
{
    return false;  // also applies to 'throw', 'break', and 'continue'
}
else if (a < 10)
{
    // some statement..
}
else
{
    // some statement..
}
```

Prefer:
``` csharp
if (a == 0)
{
    return false;
}

if (a < 10)
{
    // somestatement..
}
else
{
    // some statement..
}
```

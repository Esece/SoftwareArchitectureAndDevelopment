## Dictionary with 'Type' Keys

Purposes:
* Thread-safe
* Reusable code
* Built-in feature

-----

If the key is a Type object,
``` csharp
var dictionary = new Dictionary<Type, int>();
:

dictionary.Add(typeof(string), 12345);  // note that this is not thread-safe
:

var id = dictionary[typeof(string)];
:
```

A generic class can be used instead..
``` csharp
class Dict<T>
{
    public static int Value;
}

Dict<string>.Value = 12345;
:

var id = Dict<string>.Value;
:
```

## Take Advantage of Type Inference 

Purposes:
* Less code
* Reduced cylomatic complexity
* No reinventing the wheel

-----

Before
``` csharp
var value = "123";
int id;

if (value != null && int.TryParse(null, out id))  // NO NEED TO NULL CHECK...
{
    //
}
```

After
``` csharp
var value = "123";
int id;

if (int.TryParse(null, out id))
{
    //
}
```

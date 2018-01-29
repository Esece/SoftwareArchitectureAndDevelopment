### Comments Galore

Commenting every line
``` csharp
// first get data
var data = GetData(id);

// then check
var errors = Validate(date);

// if everything is ok, save data
if (errors.Count == 0)
{
    Save(data);
}
```

> Before commenting, try making the methods and variables meaningful

### Comments Galore

Commenting like telling a story for each line
``` csharp
// first get data
var data = GetData(id);

// then check
var errs = Validate(date);

// if everything is ok, save data
if (errs.Count == 0)
{
    Save(data);
}
```

Commenting a poorly-named variable
``` csharp
var n = textbox.Text;
:

Save(n);  // saving name
```

> Before commenting, try making the methods and variables meaningful


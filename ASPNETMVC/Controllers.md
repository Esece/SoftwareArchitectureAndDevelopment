### Controllers

Use a Single "Model" Parameter over Multiple Primitive Parameters
``` csharp
// PREFER
public ActionResult Index(LoginModel model)
{
    :
}

public class LoginModel
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool Remember { get; set; }
}

// AVOID
public ActionResult Index(string userName, string password, bool remember)
{
    :
}
```
> Having a model also simplifies passing data to a view
``` csharp
return View("Index", model);
```


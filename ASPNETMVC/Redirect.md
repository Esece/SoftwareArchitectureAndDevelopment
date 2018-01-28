## Redirect

Use Post-Get-Redirect Pattern for POST actions
``` csharp
[HttpGet]
public ActionResult Login()
{
    :
}

[HttpPost]
public ActionResult Login(string name, string password)
{
    :
    if (success)
    {
        return Redirect("Main");
    }
    else
    {
        return Redirect("Login");  // avoid return Index("Login")
    }
}
```

Check if Response is Redirect
``` csharp
if (Response.IsRequestBeingRedirected)
{
  :
}
```

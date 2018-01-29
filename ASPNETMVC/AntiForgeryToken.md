### Anti-Forgery Token

##### Prevent other sites from submitting data

> WARNING: This is only effective when the request is sent from a web browser. Requests can still be sent programmatically via a simple HTTP request

View
``` csharp
<form method="post"... >
  @Html.AntiForgeryToken()
  :
</form>
```

Controller
``` csharp
[ValidateAntiForgeryToken]
public ActionResult ForgotPassword(string userName)
{
    :
}
```

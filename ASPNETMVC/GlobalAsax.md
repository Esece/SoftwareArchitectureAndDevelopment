### Global.asax

Handle Unhandled Exceptions Globally
``` csharp
public class MvcApplication : HttpApplication
{
    void Application_Error(object sener, EventArgs e)
    {
        var exception = Server.GetLastError();
        :
        
        Server.ClearError();
    }
}
```

### Global.asax

Handle Unhandled Exceptions Globally
``` charp
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

## ASP.NET MVC
#### It's more than Model-View-Controller.

|ASP.NET MVC Component|Primary Responsibility|Other Roles|
|---------------------|----------------------|-------|
|(View)Models|Holds data entered by user and data to display to user|Basic validation|
|Views|Presents data|Serialization, Translation|
|Controllers|Routes data for processing and select output type based on process results (i.e. View, Redirect, Json)||
|Routes|Maps the URL to the controller and the action|Simple model binding|
|Action Results|Prepares HTTP response with status and data|Serialization|
|Authorize Filter|Performs authentication and authorization and returns HTTP 401 (authentication) or HTTP 403 (authorization)||
|Action Filters|Performs preprocessing and postprocessing tasks||
|Model Binders|Binds request data to Action parameters|Conversion, deserialization, validation|
|Value Providers|Looks up data in Http request||
|ModelState|Holds validated data and validation errors||

#### Do NOT let HTTP Context objects go beyond controllers
* Raw Request Data (Form, JSON, XML, etc.)
* Cookie
* Session
* Request Headers
* Client Data (IP Address)
* HTTP Method

> These values must be mapped to controller parameters if needed to be passed for further processing

#### Avoid performing serialization and conversion in controllers
Action Taking Converted, Strongly-Typed Arguments
``` csharp
public ActionResult SignIn(string username, string password, AccountType accountType, bool rememberMe)
{
    :
}
```

Avoid Operate HTTP Request Directly in a controller
``` csharp
// AVOID
public ActionResult SignIn(string username, string password)
{
    if (Request["RememberMe"] == "on")
    {
        :
    }
    :
}
```

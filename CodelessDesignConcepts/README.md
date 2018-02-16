# Codeless Design Concepts
There will be less "coding" in the future. As more and more components and modules become standardized and commoditized, most business problems will be solved simply by selecting the right components and designing a pipeline.
Must of the programming will be for designing generic algorithms and components. 

-----

### More Declarative Than Imperative
Declarative
``` xml
<appSettings>
  <add key="ClientValidationEnabled" value="true" />
```

Imparative
``` csharp
HtmlHelper.ClientValidationEnabled = true;
```

Benefits of Being Declarative
- Focus on what it is instead of how it is done
- No need to care about control flow
- More human-readable

**This is already the case in much of frontend programming like HTML and CSS.**

-----
### More Standard Than Custom

* Utilize the standard libraries and common frameworks as much as possible
* Skip testing the standard library implementation ('Custom' means you should unit-test.)
* Use free solutions if they suit your needs, but evaluate the cost of maintenance and any extra development very carefully
* When a custom solution is needed, keep it general purpose and make it reusable at least.

-----
### Convention over Configuraiton

* Well-Document the use of terms and identifier names.
* Convention-based coupling is looser than configuration-based. (very often runtime resolved.)

ASP.NET MVC Example
``` csharp
public class Document
{
    public ActionResult Invoice(string invoiceNumber)
    {
        :
        return View();  // Calling a view named'Invoice' (from the method name) located under 'Document' (from the class name).
    }
}
```

Scenario-Based Example

> **If a dependency injection container finds exactly one implementation class for an interface (definition), it can assume the interface can be bound to the class. This convention eliminate the need for a line like "container.Bind<IBox, Box>()"**

Common Use Cases
- Mapping
- Grouping
- Searching

-----
### Aspect-Oriented Design

**One typical example in C# is decorating a method with an attribute**

ASP.NET MVC "Action Filter"
``` csharp
[Authorize]  // Only an 'authorized' request can call the implementation..
public class UserProfile
{
    :
}
```

> C# Attributes act like configuration

Usually to avoid mixing business logic with cross-cutting concerns like this:
``` csharp
if (user.IsAuthorized)
{
    :  // business logic here..
```



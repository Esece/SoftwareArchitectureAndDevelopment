### Prefer LINQ to a simple loop

Avoid:
``` csharp
var errorMessages = new List<string>();

foreach (var notification in notifications)
{
    errorMessages.Add("Response: " + notification.Message);
}

response.Errors = errorMessages.ToArray()
```

Prefer:
``` csharp
response.Errors = notifications.Select(n => "Response: " + n.Message).ToArray();
```

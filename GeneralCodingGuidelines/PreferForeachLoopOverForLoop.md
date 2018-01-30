### Prefer foreach Loop to for Loop

Avoid:
``` csharp
for (int i = 0; i < notifications.Length; i++)
{
    errorMessages.Add("Response: " + notifications[i].Message);
}
```

Prefer:
``` csharp
foreach (var notification in notifications)
{
    errorMessages.Add("Response: " + notification.Message);
}
```

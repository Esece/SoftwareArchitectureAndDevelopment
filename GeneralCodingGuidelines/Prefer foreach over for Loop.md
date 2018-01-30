### Prefer foreach Loop over for Loop

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

> The fewer variables you use, the easier maintanance and troubleshooting will become later.

> A foreach loop ensures and indicates that the collection is used as readonly.

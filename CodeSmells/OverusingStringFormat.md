## Overusing String.Format()

Using String.Format for not formatting purposes
``` csharp
String.Format("Error: {0}", message)
```

Simple and more performance efficient
``` csharp
"Error :" + message
```

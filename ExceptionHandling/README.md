# Exception Handling

### Simple Guidelines
* Use try-catch for external calls.
* Do not create and throw an Exception instance. (Throw an ApplicationException if not a custom exception.)
* Do not catch a NullReferenceException. (This is a programing error. Check for null explicitly instead.)
* Use separate catch statements for each exception. (Do not type-check an exception.)

### General Guidelines

* Use try-catch for operations that might not work all the time. 
* Try not to "catch all". (It is OK to start doing so and then refine later when there are no side effects and the process can be repeated.)
``` csharp
try
{
    ...
}
catch (Exception ex)
{
    ....
}
```

* Wrap a domain-specific exception with a custom exception
``` csharp
try
{
    ...
}
catch (SqlException ex)
{
    // wrap this domain-specific exception instead of passing it on..
    throw new NameNotFoundException("The specified name does not exist.", ex);
}
```

* Log exceptions that need to be monitored and/or fixed.

> Craching an application due to an unhandled exception may sometimes be a better solution than keeping it running in a corrupted state.

### When to Use try-catch
* IO operations (database calls, file systems, web requests, etc.)







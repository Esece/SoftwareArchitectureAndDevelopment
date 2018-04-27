### out/ref Parameters with void Return Type

Method with ref/out parameters and void return Type
``` csharp
void GetCounts(Guid id, out int pendingCount, out int processedCount, out int expiredCount, out int failedCount)
{
    :
}
```

Create a Class that holds the values and return an object instead
``` csharp
class ProcessResultInfo
{
    public Guid Id { get; set; }
    public int PendingCount { get; set; }
    public int ExpiredCount { get; set; }
    public int FailedCount { get; set; }
}
:

ProcessResultInfo GetCounts(Guid id)
{
    :
    return info;
}
```

> Unless a method cannot operate with a "copy" of a ValueType object, do not use out or ref parameters.


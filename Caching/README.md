# Caching


### Caching Adds Complexity
**When considering caching, carefully evaluate performance benefits and added complexity.**

Evaluation Check Points:
* Cache or No Cache
* Cache or Optimize Logic
* Setup Cost
* Setup Timing (startup, lazy, nondeterministic, etc.)
* Flushing and Updating
* Location (in-memory within application, in-memory outside application, remote, client-side, CDN, file/disk, etc.)
* Data Format (objects, serialized, etc.)
* Sharing (single application cache or cache consumed by multiple applications)
* Cache Dependency
* Fallback Strategies
* Double Caching

> Caching as well as optimization in general should be the LAST part of development. Always measure performance and compare against performance requirements. DO NOT over-cache even if space is not an issue.

### Cache or No Cache

Typical Items to Cache:
- Static Data and References
- Reports and Documents
- Parameterized Compiled Queries
- Dynamic Methods

Avoid Caching These Items:
- Session
- Transactional Data
- Profile Data


### Cache or Optimize Logic

Before caching a data set resulting from a slow process, see if the process can be improved. Caching may not be necessary.

### Setup Cost

- Cache Key Generation
- Locking (Avoid double initialization)
- Maintaining Cache Objects
- Any services and agents to run?

A simple example of local cache with double checked locking 
``` csharp
static Dictionary<string, object> Cache = null;
static object _locker = new object();
:

if (Cache == null)
{
    lock (_locker)
    {
        if (Cache == null)
        {
            // SLOW PROCESS HERE
            Cache = data;                       
        }
    }
}
:
```

### Setup Timing (startup, lazy, nondeterministic, etc.)

* 



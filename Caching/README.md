# Caching


### Caching Adds Complexity
> **CAUTION: When considering caching, carefully evaluate performance benefits and added complexity.**

Evaluation Check Points:
* Cache or No Cache
* Cache or Optimize Logic
* Setup Cost
* Setup Timing (startup, lazy, nondeterministic, etc.)
* Flushing and Updating
* Location (in-memory within application, in-memory outside application, remote, client-side, CDN, file/disk, etc.)
* Data Format (objects, serialized, etc.)
* Sharing (single application cache or cache consumed by multiple applications)
* Cache Dependencies
* Fallback Strategies

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
- Data Already Cached Somewhere Else


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

#### Application Startup

An ASP.NET Example (global.asax.cs)
``` csharp
public class WebApplication : System.Web.HttpApplication
{
        protected void Application_Start()
        {
            :
```

> In fact, the ASP.NET framework sets up a lot of lookup data cache at startup.

#### Lazy

A Simple Object Cache with Lazy<T> in C#
``` csharp
public class MySingleton
{
    static readonly Lazy<IDictionary<string, string>> Cache = new Lazy<IDictionary<string, string>>(() => GetData());

    static IDictionary<string, string> GetData()
    {
        // A TIME-CONSUMING PROCESS HERE
    }
    
    public void DoSomething(string value)
    {
        var result = Cache.Value[value];  // WHEN HIT FOR 1ST TIME, CACHE GETS LOADED..
        :
    }
}
```

An Example of Property Caching
``` csharp
public class SubstringInfo
{
    string _source;
    string _text;  // cache

    public SubstringInfo(string source, int index, int length)
    {
        _source = source;
        Index = index;
        Length = length;
    }

    public int Index { get; protected set; }
    public int Length { get; protected set; }

    public string Text
    {
        get { return _text ?? (_text = _source.Substring(Index, Length)); }  // 2nd time will skip the processing...
    }
}
``

#### Nondeterministic

This is when cache is created at an unspecified point of time. There may be a timer, a counter, or a sophisticated algorithm that decides when to create cache.

Possible Scenarios:
* Load cache when traffic is light
* Load cache when target data is called more than 100 times a minute 

#### Flushing and Updating

> **CAUTION: If you need to update cache, again, think twice about caching is worth the complexity.**


#### Cache Location

|Location|Examples|Pros|Cons|Usage|
|-----|-----|-----|-----|-----|
|Application Cache|local or global objects|Simple setup, Very fast read/write|Can be tainted easily. Not sharable across multiple application instances|Fast lookup, Single-instance application|
|Relational Database|SQL Server, MySql, etc.|a simple database calls|Simple setup, sharable with different applications and instances, can store large data|copying and serialization occur|calculation results, documents, sessions|
|In-Memory Database (NoSql)|Redis, Couchbase, etc.|sharable, can be managed locally (in-memory) or remotely, low/no cost|copying and/or serialization occur|structured large data|
|CDN|Akamai, MaxCDN, Cloudflare|Simple to use|Reduced stress to internal servers|High cost, may not be so simple to set up|HTML, Javascript, CSS, JSON|

> This is not about one being better than others. In many cases, especially enterprise-level applications, different cache locations are used for different purposes.

#### Cache Data Format

|Format|Pros|Cons|
|-----|-----|-----|
|Raw|Very fast(simple address assignment)|Can be tainted easily and it's hard to notice.|
|Serialized (JSON, XML)|Essentially clones|Copying and serialization cost|
|Compressed|Reduced size|Same as serialized object, plus compression and decompression cost|

#### Cache Sharing

Shareability dependes on the cache location

|Location|Same Instance|Different Instance|Different Application|Different Servers|
|-----|-----|-----|-----|-----|
|Application Cache|YES|NO|NO|NO|
|Relational Database|YES|YES|YES|YES|
|NoSql Database|YES|YES|YES|YES|

#### Cache Dependencies

> **CAUTION: This is yet another point where you need to rethink about caching. Unless you have a very robust caching and fallback strategies, do not cache items that have dependencies on either another cache item or a non-cached item.**

An Example of Cache Dependency:
1. Product data gets cached
2. Formatted product header for optimzing search gets created and cached
3. A product name has changed
4. Flush the product data cache
5. product header data update gets triggered (CACHE DEPENDENCY)

#### Fallback Strategies

- Profile cache items for severity and importance
- Consider redundancy or even shutdown if critical item caching fails
- Gracefully fall back to the non-caching process (usually already exists as part of the setup process)





# Caching


### Caching Adds Complexity
**When considering caching, carefully evaluate performance benefits and added complexity.**

Evaluation Check Points:
* Cache or Optimize Logic
* Setup Cost
* Setup Timing (startup, lazy, nondeterministic, etc.)
* Concurrency and Locking (Avoid double initialization)
* Flushing and Updating
* Location (in-memory within application, in-memory outside application, remote, file.etc.)
* Data Format (objects, serialized, etc.)
* Fallback Strategies

> Caching as well as optimization in general should be the LAST part of development. Always measure performance and compare against performance requirements. DO NOT over-cache even if space is not an issue.

### Setup Cost

### Software Engineers - Difference between Good and Bad

|Good Engineers|Bad Engineers|Remarks|
|-----|-----|-----|
|Convert data to the right type as soon as it is read|Convert data when and where it is used|Unconverted data can be of string or object type|
|Serialize data when there is no more operation of it|Serialize data too early causing deserialization down the process||
|Write a fewer lines of code|Write more lines of code|The difference is often 1:3+|
|Define a fewer variables|Define more variables||
|Know what exceptions to catch and handle|Catch all exceptions at once||
|Use 'Dictionary' for lookup operations|Use switch statements for lookup operations||
|Use empty lines to separate logical groups|Eliminate empty lines to fit more code.||
|Break up a long statement into small, multiple statements in separate lines|Word-wrap a long statement||
|Define classes for different types of operations|Use #region tags to group different operations within a single class||
|Use a meaningful variable name such as 'firstName.'|Use a short, cryptic name such as 'fn.'|| 
|Avoid static objects and stateful static methods (C#)|Use static objects and stateful static methods for convenience||
|Use a string type for US Zip Codes|Use an integer type for US Zip Codes||
|Keep a lambda expression short (C#)|Write a long, multi-line lambda expression (C#)||
|Return an object for returning multiple values from a method (C#)|Use 'out' parameters to return multiple values from a method (C#)||
|Limit 'Tuple' objects to storing and passig values within a variable or a class (C#)|Use 'Tuple' as a return type of a public method (C#)||
|A method is private by default|A method is public by default|
|Write self-documenting code|Write a lot of code comments|
|Use signed numeric types for public method parameters|Use unsigned or short numeric types because they are more space-efficient|
|Make backward-compatible changes or add new features without changing the current|Make breaking changes often introducing unplanned changes to be made elsewhere||
|Shallow call stacks|Deep call stacks|A large call stack can be an indication of spaghetti code.|
|Use logging to discover bugs and exceptional events|Use logging to help debug||
|Use caching with proper cache management (duration, dependency, events, etc.)|Just cache as much data as possible to speed up||
|Make static methods thread-safe|Leave static methods thread-unsafe||
|Organize namespaces and classes by functional area|Organize namespaces and classes as files and folders|These are two completely different purposes. One designed for developers using the code, the other for the code writer's benefits|


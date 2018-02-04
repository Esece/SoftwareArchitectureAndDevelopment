# DO NOT use 'const' for public members

### const keyword (C#)

'const' is build-time binding, meaning that any changes to the 'const' value forces caller assemblies to rebuild.
``` csharp
// DO NOT DO THIS
public const string Name = "Box";
```

The compiled assembly (dll) holds the value in the metadata.
```
07 42 00 6F 00 78 00  .B.o.x..
```

The caller also calls the ldstr instruction for a const string
```
ldstr (reference to the value)
```

### readonly keyword (C#)

#### DO USE 'readonly' for public members

'readonly' is runtime binging just like an ordinary field.
``` csharp
public readonly string Name = "Box";
```
It can also be used for non-constant values unlike 'const'.
``` csharp
public readonly Uri Url = _uri;
```

As opposed to 'const,' the caller also calls the ldfld instruction.
```
ldfld (reference to the class and the value)
```


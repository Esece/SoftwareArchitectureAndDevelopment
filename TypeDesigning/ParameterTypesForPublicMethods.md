## Parameter Types for Public Methods (C#)

#### Recommended Types
|Usage|Recommended|Avoid|Remarks|
|-----|-----|-----|-----|
|Whole Number|**int**|short, sbyte, long|Unless a number is expected to be larger than Int32, avoid Int64 as most libraries are (still) designed to take Int32 as parameters.|
|Positive Whole Number|**int**|uint, ushort|The rationale here is to avoid casting for method calls of the libraries.
|Decimal Number (fraction)|**double**|decimal, float|Again for compatibility reasons. Reserve 'float' for high performance situations only.|
|Monetary Value|**decimal**|float, double|You might not do any arithmetic operations, but this is more of a convention for representing monetary values.|
|Flag (True/False, On/Off)|**bool**|byte||
|Alphanumeric|**string**|char[], StringBuilder|




<!--
> Probably very few software engineers like to see a lot of casting and converting in their code. In fact, Casting and converting are much like serialization.  
-->

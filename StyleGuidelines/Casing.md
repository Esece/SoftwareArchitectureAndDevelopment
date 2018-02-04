### Casing
``` csharp
namespace AdvancedTech.ShippingPro  // namespace: pascal case
{
    public class OrderProcessor  // class name: pascal case
    {
        public bool AllowAnonymous { get; set; }  // property name: pascal case

        public bool EnableXyz { get; set; }  // An acronym is lower cased with a capital initial where pascal case is used (i.e. XYZ -> Xyz)

        public int MTCount { get; set; }  // An two-letter acronym is capitalized where pascal case is used (i.e. MT -> MT)

        public static readonly int Version = 2;  // public fields: pascal case

        public bool IsValidOrderNumber(string orderNumber)  // method name: pascal case, parameter name: camel case
        {
            bool isValid;  // local variable: camel case
            :
        }
    }
}
```

|Type|Case|Examples|
|----|------|--------|
|Namespace|Pascal|AdvancedTech.ShippingPro|
|Type (Class, Struct, Enum, Interface)|Pascal|OrderProcessor, MTCalculator, IValidator|
|Member (Property, Method, Events, Public Fields)|Pascal|FullName, Validate(), Clicking|
|Parameter, Local|Camel|orderStatus|
|Imported types and methods|(Use original)|ImageList_AddMasked, WM_CLOSE|

**The casing for private members and locals do not need to be very strict as long as they are distinct and consistent.**
``` csharp
// THIS IS OK
public class Processor
{
    string m_name;  // 'm_' prefix
    :
    
    public Processor(string name)
    {
        :
```

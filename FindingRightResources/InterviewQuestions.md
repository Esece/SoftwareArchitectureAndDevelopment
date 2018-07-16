## Issues with Interview Questions

### Facts
* So many companies ask questions that are just too academic or too impractical in their actual development environment.
* So many interviewers ask questions they cannot even answer correctly.
* So many questions lack context and yet expect generic solutions to the problems, when in real life, context plays a big role in decision making.

### Examples of Academic Questions
|Question|Issue|
|-----|-----|
|Is string a value type or reference type in C#?|Understanding how a string type is designed would be more useful.|
|What is the difference between Boxing and Unboxing?|The issue to discuss should be rather using the object type to store a value type. Still, the boxing cost is insignificant in many applications.|


### Sample Questions for Language Details (C#)
|Question|Notes|
|-----|-----|
|How would you name a local variable that you want to call "Shipping API?"  1) Shipping_API, 2) shipping_api, 3) shippingAPI, 4) ShippingAPI, 5) shippingApi|At least in C#, 5 is the most common name. Choosing 3 indicates that the candidate may not be familiar with the conventions or be simply careless about details.|


### Sample Questions for Finding "Not-so-good" Practices (C#)
``` csharp
class Request
{
    public string[] Credentials;
}
```
``` csharp
public void ProcessDocument(Document document, out string[] messages)
{
    :
}
```
``` csharp
DateTime date = default(DateTime);
if (DateTime.TryParse(value, out date))
{
```
``` csharp
public void UpdatePhoneNumber(ref Document document, string phoneNumber)
{
    var num = phoneNumber.Trim();
    document.Phone = num;
}
```

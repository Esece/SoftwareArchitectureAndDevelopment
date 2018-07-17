## Issues with Interview Questions

### Facts
* Many companies ask questions that are just too academic or too impractical in their actual development environment.
* Many interviewers ask questions they cannot even answer correctly.
* Many questions lack context and yet expect generic solutions to the problems, when in real life, context plays a big role in decision making.
* Many questions are expected to be answered with single specific right solutions that interviewers were looking for.
* Many expected answers are not related to work candidates would be doing.


### Examples of Academic Questions
|Question|Issue|
|-----|-----|
|Is string a value type or reference type in C#?|Understanding how a string type is designed would be more useful.|
|What is the difference between Boxing and Unboxing?|The issue to discuss should be rather using the object type to store a value type. Still, the boxing cost is insignificant in many applications.|
|Reverse a string without using a library method|This is reinventing the wheel. Unless you work for a library vendor, it is not generally a good idea to write custom code unrelated to your core business. In fact, there are already many free solutions for string reversing. It's not a good way to measure creativity.|
|What are the 3 principles of OOP?|Inheritance, encapsulation, and polymorphism are usually expected to be mentioned. However very rarely interviewers expect to hear when these principles are useful and when they are not.|

<br/>

> OOP is mentioned in almost every job description and is often considered best though developers cannot always explain other paradigms.

<br/>

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
``` csharp
public ResponseModel UpdateProfile(Profile profile)
{
    ResponseModel response = null;

    try
    {
        :

        response = new ResponseModel() { Success = isSuccess, Messages = messages };
    }
    catch (Exception ex)
    {
        response = new ResponseModel() { Success = false, Messages = errorMessages };
    }

    return response;
}
```
``` csharp
decimal price = 499.99m;
:

if ((int)price > 0)
{
    :
}
```




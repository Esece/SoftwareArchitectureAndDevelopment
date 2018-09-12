## Issues with Interview Questions

### In Reality
* Many companies ask questions that are just too academic or seemingly unrelated to their actual development environment.
* Many interviewers ask questions they cannot answer with much explanation.
* Many questions lack context and yet expect somewhat particular solutions to the problems, when in real life, context plays an important role in decision making.


### Examples of Academic Questions
|Question|Issues|
|-----|-----|
|Is string a value type or reference type in C#?|C# string is an immutable type, so it's extremely difficult to see unexpected side effects. If the question is to understand the difference between value type and the reference type, ask this question directly instead. Also explaining how a string type is designed, such as immutability, would be more useful knowledge to test.|
|What is the difference between Boxing and Unboxing?|At least two things interviewers expect to hear would be the boxing cost and the copying. Though asking about how to design a struct type may be more interesting, in much coding, custom structs are very rarely created, and boxing itself does not occur very often. Even if it does, the cost is insignificant in many applications.|
|Reverse a string without using a library method|This is reinventing the wheel. Unless you work for a library vendor, it is not generally a good idea to write custom code unrelated to your core business. In fact, there are already many free solutions for string reversing. It's not a good way to measure creativity.|
|What are the 3 principles of OOP?|Inheritance, encapsulation, and polymorphism are usually expected to be mentioned. However many interviewers don't expect to hear beyond what they mean.|

<br/>

> OOP is mentioned in almost every job description and is often considered best, although developers cannot always explain other paradigms and how OOP is superior to others (and when others do better). 

> In reality, many developers unconsciously use various programming styles because OOP either does not fit very well or is simply impractical or counter-productive.

<br/>

### Sample Questions for Language Details (C#)
|Question|Notes|
|-----|-----|
|How would you name a local variable that you want to call "Shipping API?"  1) Shipping_API, 2) shipping_api, 3) shippingAPI, 4) ShippingAPI, 5) shippingApi|At least in C#, 5 is the most common name. Choosing 3 indicates that the candidate may not be familiar with the conventions or be simply careless about details.|


### Sample Questions for Creativity  (C#)
Implement the following without conditionals
``` csharp
if (value >=0)
{
    return "+" + value.ToString();  // "+456" for 456; "+0" for 0
}
else
{
    return value.ToString();  // "-123" for -123
}
```
<!-- value.ToString(((char)(((value >> 31) + 1) * 43)) + "0") -->

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

**[See more...](InterviewQuestions-FindCodingIssues.md)**




## Sample Interview Questions
#### Point Out Any Coding Issues and Share Some Ways to Improve

> **There is no compilation issues. Answer without using an IDE.**

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
``` csharp
var count = $"{box.InnerCount}";
```
``` csharp
var total = result.Amounts != null && result.Amounts?.Any() == true ? result.Amounts?.Sum() : 0;
```
``` csharp
var details = new ConcurrentBag<Detail>();

foreach (var h in headers)
{
    var mapped = new List<Detail>();
    Map(h, mapped);
    foreach (var m in mapped)
    {
        details.Add(m);
    }
}

item.Details = details.ToArray();

```
``` csharp
if (countryCode?.Trim()?.ToUpper() == "US")
{
    :
}
```
``` csharp
public static string GetRandomString(int length)
{
    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    var random = new Random();
    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
}
```

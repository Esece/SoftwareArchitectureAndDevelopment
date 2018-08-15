## Interview Questions
#### Find Coding Issues (How can we improve?)

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


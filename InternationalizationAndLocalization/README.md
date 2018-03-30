## Software Internationalization and Localization

* Sometimes shorten to "I18N" and "L10N" respectively
* For your global software success

### Language and Culture
* About translation and format
* "en-US" means the English language in the United States

### Challenges
* The quality of translation
> Your translator or translation services must be familar with industry terms in addition to local phrases.

### Detecting the User Language and Culture
* From User Preferences (simplest and the most accurate way)

* From Windows (User Machine and a Desktop Application)
.NET offers two settings
``` csharp
System.Globalization.CultureInfo.CurrentCulture (Date, Currency, Double, etc.)
System.Globalization.CultureInfo.CurrentUICulture (Translation)
```

* From Web Users

Browsers send 'Accept-Language' header in HTTP request
```
Accept-Language: fr-CH, fr;q=0.9, en;q=0.8, de;q=0.7, *;q=0.5
```
> 'Accept-Language' header is not guaranteed to be present. Therefore, the application should have the default settings.

Client IP Address
``` csharp
string GetIPAddress()
{
    var request = System.Web.HttpContext.Current.Request; 
    string ipAddress = request.ServerVariables["HTTP_X_FORWARDED_FOR"];

    if (!String.IsNullOrEmpty(ipAddress))
    {
        var addresses = ipAddress.Split(',');
        if (addresses.Length != 0)
        {
            return addresses[0];
        }
    }

    return request.ServerVariables["REMOTE_ADDR"];
}
```
>This can point to where the request came from, but it may not be where the client is located.

### Timezone
Desktop applications can easily get the user's local time from Windows
``` csharp
DateTime.Now
```

Web Applications may need custom implementation
``` javascript
// set the offset (in minutes) to cookie 
document.cookie = 'TimezoneOffset=' + new Date().getTimezoneOffset().toString(); 
```



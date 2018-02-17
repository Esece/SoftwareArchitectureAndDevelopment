#### HTML
## Use Identifiers for HTML 'select' Options

Use identifiers for 'value' and user-friendly names for text:
``` html
<select name="PackageType">
  <option value=""></option>
  <option value="10">Box</option>
  <option value="20">Crate</option>
  <option value="30">Wire Basket</option>
  <option value="40">DW/TW</option>
</select>
```
> Using identifiers ("ID") simplifies data conversion and standardize the processing regardless of the display text, which could vary if internationalization is supported. 

Avoid using the same values:
``` html
<select name="PackageType">
  <option value=""></option>
  <option value="Box">Box</option>
  <option value="Crate">Crate</option>
  <option value="Wire Basket">Wire Basket</option>
  <option value="DW/TW">DW/TW</option>
</select>
```

However, you can use non-numeric identifiers:
``` html
<select name="PackageType">
  <option value=""></option>
  <option value="BOX">Box</option>
  <option value="CRATE">Crate</option>
  <option value="WIREBASKET">Wire Basket</option>
  <option value="DWTW">DW/TW</option>
</select>
```

**You may want to allow display text for API calls.**

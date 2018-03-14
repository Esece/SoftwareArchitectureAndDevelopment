## JQuery Validate Custom Validation

Check to see the date is greater than or equal to today
``` javascript
$(function () {
  $.validator.addMethod("present-or-future-date", function (value, element) {
      return value == '' || new Date(value) >= new Date(new Date().toLocaleDateString());
  }, "The date must be the present or a future date.");

  $('form').validate();
}
```

HTML
``` html
<input type="text" name="ShipDate" data-rule-present-or-future-date="true" data-msg-present-o-future-date="Invalid Date">
```

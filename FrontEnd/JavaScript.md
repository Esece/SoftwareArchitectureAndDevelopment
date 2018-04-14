## JavaScript

**IE11 largely doesn't support ES6.**
Avoid ES6 features if the end users are still using Internet Explorer
``` javascript
[123,987].map(i => i > 500)  // you will see 'Syntax error' in IE11...
```
Rewritten
``` javascript
[123,987].map(function(i) { return i > 500; })  // you will see 'Syntax error' in IE11...
```

> It is highly recommended that you keep track of your own browser market share.


(Usually) Put Scripts at the Bottom
``` html
:
  <script src="script.js" ></script>
</body>
</html>
```
> The type attribute is not needed

Use camelCase for names
``` javascript
function sendName() {
  var firstName = 'Mike';
  :
}
```

End with a Semicolon
``` javascript
var names = ["Ken", "John"];
```

Place the opening bracket on the statement start line
``` javascript
for (i = 0; i < 4; i++) {
    x += 1;
}
```

Declare Variables at the Top
``` javascript
var x = 5;
var y;
```
> JavaScript declarations are hoisted. Without understanding which, programs may contain bugs and errors. 

Minify Script Files
``` javascript
for(i=0;i<4;i++){x+=1;}
```

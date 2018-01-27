### JavaScript

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

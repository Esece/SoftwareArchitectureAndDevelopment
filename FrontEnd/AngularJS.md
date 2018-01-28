### AngularJS

Prefer Initializing at the Bottom of Page
``` html
  <script>
    var app = angular.module('app', []);
    :
  </script>
</body>
</html>
```
> Use 'ng-cloak' if flickering needs fixing.


Prefer Initializing before jQuery
``` html
  <script>
    var app = angular.module('app', []);
    :
  </script>
  <script src="http://code.jquery.com/jquery-3.3.1.slim.min.js""></script>
```

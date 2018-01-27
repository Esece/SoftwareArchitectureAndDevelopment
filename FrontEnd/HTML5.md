### HTML5

``` html
<!DOCTYPE html>
```
> The default character encoding in HTML5 is UTF-8

Prefer Lower Case Names (Elements, Attributes)
``` html
<section class="sct">
  <p>Testing...</p>
</section>
```

Prefer Spaceless
``` html
<link rel="stylesheet" href="style.css" />
```

Use Server-Side Comments When Possible and Convenient (Comments do not add value to the browser.)
``` html
<!-- html comment -->
@* razor (cshtml) comment *@
```
> You could remove comment as part of minification as well.

Minification
``` html
<section class="sct"><p>Testing...</p></section>
```

Gzip Compression
```
Content-Encoding: gzip
```

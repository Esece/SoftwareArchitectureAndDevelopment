# HTML

HTML5
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

Keep Script-Free (Avoid)
``` html
<button onclick="save()" >Save</button>
```
Keep Script-Free (Prefer)
``` html
<button>Save</button>
:
$('button').on('click', save);
```

Use 'data-*" Attribute for dynamic markup components
``` html
<span data-msg="An error occurred."></span>
```
> Avoid markup components in a script section or file.

Avoid Inline Styling
``` html
<div style="color:red;" />
```
> Define styles in a CSS file and use classes instead

Minification
``` html
<section class="sct"><p>Testing...</p></section>
```

Gzip Compression
```
Content-Encoding: gzip
```
